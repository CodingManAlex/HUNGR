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
using Microsoft.AspNetCore.Identity;

namespace HUNGR.WebApp.Controllers
{
    public class FoodTrucksController : Controller
    {
        private readonly HUNGRDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> SignInManager;

        public FoodTrucksController(SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> userManager, HUNGRDbContext context)
        {
            this.SignInManager = SignInManager;
            this.userManager = userManager;
            dbContext = context;
        }


        // GET: FoodTrucks
        public async Task<IActionResult> Index()
        {
            var hUNGRDbContext = dbContext.FoodTrucks.Include(f => f.ApplicationUser).Include(f => f.FoodCategory);
            return View(await hUNGRDbContext.ToListAsync());
        }

        // GET: FoodTrucks/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodTruck = await dbContext.FoodTrucks
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

            var foodTruck = await dbContext.FoodTrucks
                .Include(f => f.ApplicationUser)
                .Include(f => f.FoodCategory)
                .Include(f => f.Reviews)
                .Include(f => f.UserFavouriteTrucks)
                .FirstOrDefaultAsync(m => m.FoodTruckId == id);
            if (foodTruck == null)
            {
                return NotFound();
            }

            FoodTruckProfileViewModel truckProfile = new FoodTruckProfileViewModel
            {
                FoodTruckModel = foodTruck

            };

            return View(truckProfile);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview(FoodTruckProfileViewModel model)
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

                return RedirectToAction("Profile", new { id = review.FoodTruckId } );
            }


            return View(model);
        }

        public async Task<IActionResult> AddTruckToFavourite(UserFavouriteTruck model)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(model);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Profile", new { id = model.FoodTruckId });
            }

            return View();
        }






        // GET: FoodTrucks/Create
        public IActionResult Create()
        {
            ViewData["FoodTruckId"] = new SelectList(dbContext.Users, "Id", "Id");
            ViewData["FoodCategoryId"] = new SelectList(dbContext.FoodCategories, "Id", "Id");
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
                dbContext.Add(foodTruck);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FoodTruckId"] = new SelectList(dbContext.Users, "Id", "Id", foodTruck.FoodTruckId);
            ViewData["FoodCategoryId"] = new SelectList(dbContext.FoodCategories, "Id", "Id", foodTruck.FoodCategoryId);
            return View(foodTruck);
        }

        // GET: FoodTrucks/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodTruck = await dbContext.FoodTrucks.FindAsync(id);
            if (foodTruck == null)
            {
                return NotFound();
            }
            ViewData["FoodTruckId"] = new SelectList(dbContext.Users, "Id", "Id", foodTruck.FoodTruckId);
            ViewData["FoodCategoryId"] = new SelectList(dbContext.FoodCategories, "Id", "Id", foodTruck.FoodCategoryId);
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
                    dbContext.Update(foodTruck);
                    await dbContext.SaveChangesAsync();
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
            ViewData["FoodTruckId"] = new SelectList(dbContext.Users, "Id", "Id", foodTruck.FoodTruckId);
            ViewData["FoodCategoryId"] = new SelectList(dbContext.FoodCategories, "Id", "Id", foodTruck.FoodCategoryId);
            return View(foodTruck);
        }

        // GET: FoodTrucks/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodTruck = await dbContext.FoodTrucks
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
            var foodTruck = await dbContext.FoodTrucks.FindAsync(id);
            dbContext.FoodTrucks.Remove(foodTruck);
            await dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodTruckExists(string id)
        {
            return dbContext.FoodTrucks.Any(e => e.FoodTruckId == id);
        }
    }
}
