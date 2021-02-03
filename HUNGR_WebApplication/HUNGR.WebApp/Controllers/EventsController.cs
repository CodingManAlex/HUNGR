using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HUNGR.WebApp.Data;
using HUNGR.WebApp.Models;
using HUNGR.WebApp.ViewModels;

namespace HUNGR.WebApp.Controllers
{
    public class EventsController : Controller
    {
        private readonly HUNGRDbContext dbContext;

        public EventsController(HUNGRDbContext context)
        {
            dbContext = context;
        }

        // GET: Events
        public async Task<IActionResult> Index()
        {
            return View(await dbContext.Events.ToListAsync());
        }


        // GET: Events/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                ViewBag.ErrorMessage = $"The Event with Id = {id} cannot be found";
                return View("NotFound");
                //return NotFound();
            }

            var thisEvent = await dbContext.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thisEvent == null)
            {
                ViewBag.ErrorMessage = $"The Event with Id = {id} cannot be found";
                return View("NotFound");
            }
            List<EventParticipant> eventParticipants = dbContext.EventParticipants.Where(ep => ep.EventId == id).ToList();
            List<FoodTruck> eventTrucks = new List<FoodTruck>();

            foreach( var ep in eventParticipants)
            {
                var truckId = ep.FoodTruck;
                FoodTruck foodTruck = dbContext.FoodTrucks.FirstOrDefault(ft => ft.FoodTruckId == ep.FoodTruckId);
                eventTrucks.Add(foodTruck);
            }
            EventDetailsViewModel model = new EventDetailsViewModel()
            {
                EventDetails = thisEvent,
                EventFoodTrucks = eventTrucks
            };

            return View(model);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Location,StartDate,EndDate,ImagePath")] Event @event)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(@event);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await dbContext.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }
    }
}
