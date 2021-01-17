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
    public class ReviewsController : Controller
    {
        private readonly HUNGRDbContext dbContext;

        public ReviewsController(HUNGRDbContext context)
        {
            dbContext = context;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            var hUNGRDbContext = dbContext.Reviews.Include(r => r.ApplicationUser).Include(r => r.FoodTruck);
            return View(await hUNGRDbContext.ToListAsync());
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await dbContext.Reviews
                .Include(r => r.ApplicationUser)
                .Include(r => r.FoodTruck)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview( FoodTruckProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                Review review = new Review
                {
                    FoodTruckId = model.FoodTruckReview.FoodTruckId,
                    UserId = model.FoodTruckReview.UserId,
                    Title = model.FoodTruckReview.Title,
                    Body = model.FoodTruckReview.Body,
                    Rating = model.FoodTruckReview.Rating,
                };
                dbContext.Add(review);
                await dbContext.SaveChangesAsync();

                return View();

            }


            return View(model);
        }

        // GET: Reviews/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(dbContext.Users, "Id", "Id");
            ViewData["FoodTruckId"] = new SelectList(dbContext.FoodTrucks, "FoodTruckId", "FoodTruckId");
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Body,Rating,FoodTruckId,UserId")] Review review)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(review);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(dbContext.Users, "Id", "Id", review.Id);
            ViewData["FoodTruckId"] = new SelectList(dbContext.FoodTrucks, "FoodTruckId", "FoodTruckId", review.FoodTruckId);
            return View(review);
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await dbContext.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(dbContext.Users, "Id", "Id", review.Id);
            ViewData["FoodTruckId"] = new SelectList(dbContext.FoodTrucks, "FoodTruckId", "FoodTruckId", review.FoodTruckId);
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Body,Rating,FoodTruckId,UserId")] Review review)
        {
            if (id != review.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    dbContext.Update(review);
                    await dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.Id))
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
            ViewData["Id"] = new SelectList(dbContext.Users, "Id", "Id", review.Id);
            ViewData["FoodTruckId"] = new SelectList(dbContext.FoodTrucks, "FoodTruckId", "FoodTruckId", review.FoodTruckId);
            return View(review);
        }

        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await dbContext.Reviews
                .Include(r => r.ApplicationUser)
                .Include(r => r.FoodTruck)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]


        private bool ReviewExists(int id)
        {
            return dbContext.Reviews.Any(e => e.Id == id);
        }
    }
}
