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
    public class UserFavouriteTrucksController : Controller
    {
        private readonly HUNGRDbContext _context;

        public UserFavouriteTrucksController(HUNGRDbContext context)
        {
            _context = context;
        }

        // GET: UserFavouriteTrucks
        public async Task<IActionResult> Index()
        {
            var hUNGRDbContext = _context.UserFavouriteTrucks.Include(u => u.ApplicationUser).Include(u => u.FoodTruck);
            return View(await hUNGRDbContext.ToListAsync());
        }

        // GET: UserFavouriteTrucks/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFavouriteTruck = await _context.UserFavouriteTrucks
                .Include(u => u.ApplicationUser)
                .Include(u => u.FoodTruck)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userFavouriteTruck == null)
            {
                return NotFound();
            }

            return View(userFavouriteTruck);
        }

        // GET: UserFavouriteTrucks/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["FoodTruckId"] = new SelectList(_context.FoodTrucks, "FoodTruckId", "FoodTruckId");
            return View();
        }

        // POST: UserFavouriteTrucks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FoodTruckId,Id")] UserFavouriteTruck userFavouriteTruck)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userFavouriteTruck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", userFavouriteTruck.Id);
            ViewData["FoodTruckId"] = new SelectList(_context.FoodTrucks, "FoodTruckId", "FoodTruckId", userFavouriteTruck.FoodTruckId);
            return View(userFavouriteTruck);
        }

        // GET: UserFavouriteTrucks/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFavouriteTruck = await _context.UserFavouriteTrucks.FindAsync(id);
            if (userFavouriteTruck == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", userFavouriteTruck.Id);
            ViewData["FoodTruckId"] = new SelectList(_context.FoodTrucks, "FoodTruckId", "FoodTruckId", userFavouriteTruck.FoodTruckId);
            return View(userFavouriteTruck);
        }

        // POST: UserFavouriteTrucks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FoodTruckId,Id")] UserFavouriteTruck userFavouriteTruck)
        {
            if (id != userFavouriteTruck.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userFavouriteTruck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserFavouriteTruckExists(userFavouriteTruck.Id))
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
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", userFavouriteTruck.Id);
            ViewData["FoodTruckId"] = new SelectList(_context.FoodTrucks, "FoodTruckId", "FoodTruckId", userFavouriteTruck.FoodTruckId);
            return View(userFavouriteTruck);
        }

        // GET: UserFavouriteTrucks/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFavouriteTruck = await _context.UserFavouriteTrucks
                .Include(u => u.ApplicationUser)
                .Include(u => u.FoodTruck)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userFavouriteTruck == null)
            {
                return NotFound();
            }

            return View(userFavouriteTruck);
        }

        // POST: UserFavouriteTrucks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userFavouriteTruck = await _context.UserFavouriteTrucks.FindAsync(id);
            _context.UserFavouriteTrucks.Remove(userFavouriteTruck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserFavouriteTruckExists(string id)
        {
            return _context.UserFavouriteTrucks.Any(e => e.Id == id);
        }
    }
}
