using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HUNGR.WebApp.Data;
using HUNGR.WebApp.Models;

namespace HUNGR.WebApp.Controllers
{
    public class FoodTrucksController : Controller
    {
        private readonly HUNGRDbContext _context;

        public FoodTrucksController(HUNGRDbContext context)
        {
            _context = context;
        }

        // GET: FoodTrucks
        public async Task<IActionResult> Index()
        {
            var hUNGRDbContext = _context.FoodTrucks.Include(f => f.ApplicationUser).Include(f => f.FoodCategory);
            return View(await hUNGRDbContext.ToListAsync());
        }

        // GET: FoodTrucks/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodTruck = await _context.FoodTrucks
                .Include(f => f.ApplicationUser)
                .Include(f => f.FoodCategory)
                .FirstOrDefaultAsync(m => m.FoodTruckId == id);
            if (foodTruck == null)
            {
                return NotFound();
            }

            return View(foodTruck);
        }

        // GET: FoodTrucks/Details/5
        public async Task<IActionResult> Profile(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodTruck = await _context.FoodTrucks
                .Include(f => f.ApplicationUser)
                .Include(f => f.FoodCategory)
                .FirstOrDefaultAsync(m => m.FoodTruckId == id);
            if (foodTruck == null)
            {
                return NotFound();
            }

            return View(foodTruck);
        }

        // GET: FoodTrucks/Create
        public IActionResult Create()
        {
            ViewData["FoodTruckId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["FoodCategoryId"] = new SelectList(_context.FoodCategories, "Id", "Id");
            return View();
        }

        // POST: FoodTrucks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FoodTruckId,Name,Bio,State=0,ProfileImage,Licence,Longitude,Latitude,InstagramLink,FacebookLink,FoodCategoryId")] FoodTruck foodTruck)
        {
            if (ModelState.IsValid)
            {
                _context.Add(foodTruck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FoodTruckId"] = new SelectList(_context.Users, "Id", "Id", foodTruck.FoodTruckId);
            ViewData["FoodCategoryId"] = new SelectList(_context.FoodCategories, "Id", "Id", foodTruck.FoodCategoryId);
            return View(foodTruck);
        }

        // GET: FoodTrucks/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodTruck = await _context.FoodTrucks.FindAsync(id);
            if (foodTruck == null)
            {
                return NotFound();
            }
            ViewData["FoodTruckId"] = new SelectList(_context.Users, "Id", "Id", foodTruck.FoodTruckId);
            ViewData["FoodCategoryId"] = new SelectList(_context.FoodCategories, "Id", "Id", foodTruck.FoodCategoryId);
            return View(foodTruck);
        }

        // POST: FoodTrucks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FoodTruckId,Name,Bio,State,ProfileImage,Licence,Longitude,Latitude,InstagramLink,FacebookLink,FoodCategoryId")] FoodTruck foodTruck)
        {
            if (id != foodTruck.FoodTruckId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foodTruck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodTruckExists(foodTruck.FoodTruckId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FoodTruckId"] = new SelectList(_context.Users, "Id", "Id", foodTruck.FoodTruckId);
            ViewData["FoodCategoryId"] = new SelectList(_context.FoodCategories, "Id", "Id", foodTruck.FoodCategoryId);
            return View(foodTruck);
        }

        // GET: FoodTrucks/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodTruck = await _context.FoodTrucks
                .Include(f => f.ApplicationUser)
                .Include(f => f.FoodCategory)
                .FirstOrDefaultAsync(m => m.FoodTruckId == id);
            if (foodTruck == null)
            {
                return NotFound();
            }

            return View(foodTruck);
        }

        // POST: FoodTrucks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var foodTruck = await _context.FoodTrucks.FindAsync(id);
            _context.FoodTrucks.Remove(foodTruck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodTruckExists(string id)
        {
            return _context.FoodTrucks.Any(e => e.FoodTruckId == id);
        }
    }
}
