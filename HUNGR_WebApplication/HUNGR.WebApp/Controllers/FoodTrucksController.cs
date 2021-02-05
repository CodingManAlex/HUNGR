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
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace HUNGR.WebApp.Controllers
{
    public class FoodTrucksController : Controller
    {
        private readonly HUNGRDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IHostingEnvironment hostingEnvironment;

        public FoodTrucksController(IHostingEnvironment hostingEnvironment,SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, HUNGRDbContext context)
        {
            this.hostingEnvironment = hostingEnvironment;
            this.signInManager = signInManager;
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
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                ViewBag.ErrorMessage = $"The FoodTruck with Id = {id} cannot be found";
                return View("NotFound");
            }

            var foodTruck = await dbContext.FoodTrucks
                .Include(f => f.ApplicationUser)
                .Include(f => f.FoodCategory)
                .FirstOrDefaultAsync(m => m.FoodTruckId == id);
            if (foodTruck == null)
            {
                ViewBag.ErrorMessage = $"The FoodTruck with Id = {id} cannot be found";
                return View("NotFound");
            }

            return View(foodTruck);
        }

        // GET: FoodTrucks/Details/5
        public async Task<IActionResult> Profile(string id)
        {
            if (id == null)
            {
                ViewBag.ErrorMessage = $"The FoodTruck with Id = {id} cannot be found";
                return View("NotFound");
            }

            var foodTruck = await dbContext.FoodTrucks
                .Include(f => f.ApplicationUser)
                .Include(f => f.FoodCategory)
                .Include(f => f.Reviews)
                .Include(f => f.UserFavouriteTrucks)
                .FirstOrDefaultAsync(m => m.FoodTruckId == id);

            if (foodTruck == null)
            {
                ViewBag.ErrorMessage = $"The FoodTruck with Id = {id} cannot be found";
                return View("NotFound");
            }

            FoodTruckProfileViewModel truckProfile = new FoodTruckProfileViewModel
            {
                FoodTruckModel = foodTruck

            };

            return View(truckProfile);
        }

        [HttpPost]
        [Authorize(Roles = "User")]
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

        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> AddTruckToFavourite(string foodTruckIdFav, string userIdFav)
        {
            var truckId = foodTruckIdFav;
            var userId = userIdFav;

            UserFavouriteTruck model = new UserFavouriteTruck
            {
                FoodTruckId = foodTruckIdFav,
                Id = userIdFav
            };

            
            dbContext.Add(model);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Profile", new { id = foodTruckIdFav });
        }
        [Authorize(Roles = "User")]
        public async Task<IActionResult> RemoveTruckFromFavourite(string foodTruckIdFav, string userIdFav)
        {
                var favouriteTrucksList = dbContext.UserFavouriteTrucks.Where(ft => ft.FoodTruckId == foodTruckIdFav).ToList();
                var userFavouriteTruck = favouriteTrucksList.Find(e => e.Id == userIdFav);

                dbContext.UserFavouriteTrucks.Remove(userFavouriteTruck);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Profile", new { id = foodTruckIdFav });
        }
        [Authorize(Roles = "FoodTruck")]
        public async Task<IActionResult> OpenFoodTruck(string foodTruckId)
        {
            FoodTruck foodTruck = await dbContext.FoodTrucks.FindAsync(foodTruckId);

            foodTruck.State = 1;

            dbContext.Update(foodTruck);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("MyProfile", "User", new { id = foodTruckId });
        }
        [Authorize(Roles = "FoodTruck")]
        public async Task<IActionResult> CloseFoodTruck(string foodTruckId)
        {
            FoodTruck foodTruck = await dbContext.FoodTrucks.FindAsync(foodTruckId);

            foodTruck.State = 0;

            dbContext.Update(foodTruck);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("MyProfile", "User", new { id = foodTruckId });
        }
        [Authorize(Roles = "FoodTruck")]
        public async Task<JsonResult> OpenCloseFoodTruckAjax(string foodTruckId, double foodTruckLat, double foodTruckLong)
        {
            FoodTruck foodTruck = await dbContext.FoodTrucks.FindAsync(foodTruckId);

            //If its open, close it
            if(foodTruck.State == 1)
            {
                foodTruck.State = 0;
            }
            //Else open it
            else
            {
                foodTruck.State = 1;
                foodTruck.Latitude = foodTruckLat;
                foodTruck.Longitude = foodTruckLong;
            }

            dbContext.Update(foodTruck);
            await dbContext.SaveChangesAsync();

            return Json(foodTruck.State);
        }


        // GET: FoodTrucks/Create
        [Authorize(Roles = "Admin,User")]
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
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> Create([Bind("FoodTruckId,Name,Bio,State=0,ProfileImage,Licence,FoodCat,Longitude,Latitude,InstagramLink,FacebookLink,FoodCategoryId")] FoodTruck foodTruck)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(foodTruck);
                await dbContext.SaveChangesAsync();
                var user = await userManager.FindByIdAsync(foodTruck.FoodTruckId);
                
                //Change Role of User to a food Truck owner
                var result = await userManager.AddToRoleAsync(user, "FoodTruck");
                if (result.Succeeded)
                {
                    var roleResult = await userManager.RemoveFromRoleAsync(user, "User");
                    if (roleResult.Succeeded)
                    {
                        await signInManager.SignOutAsync();
                        await signInManager.SignInAsync(user, true);
                        return RedirectToAction("MyProfile", "User", new { id = foodTruck.FoodTruckId });
                    }
                }

            }
            ViewData["FoodTruckId"] = new SelectList(dbContext.Users, "Id", "Id", foodTruck.FoodTruckId);
            ViewData["FoodCategoryId"] = new SelectList(dbContext.FoodCategories, "Id", "Id", foodTruck.FoodCategoryId);
            return View(foodTruck);
        }

        // GET: FoodTrucks/Edit/5
        [Authorize(Roles = "Admin,FoodTruck")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                ViewBag.ErrorMessage = $"The FoodTruck with Id = {id} cannot be found";
                return View("NotFound");
            }

            var foodTruck = await dbContext.FoodTrucks.FindAsync(id);
            if (foodTruck == null)
            {
                ViewBag.ErrorMessage = $"The FoodTruck with Id = {id} cannot be found";
                return View("NotFound");
            }
            EditFoodTruckViewModel editFoodTruckViewModel = new EditFoodTruckViewModel
            {
                FoodTruckId = foodTruck.FoodTruckId,
                FoodTruckName = foodTruck.Name,
                TruckBio = foodTruck.Bio,
                FoodCategory = (FoodEnum.FoodCat)foodTruck.FoodCat,
                InstaLink = foodTruck.InstagramLink,
                FacebookLink = foodTruck.FacebookLink,
                ExistingImagePath = foodTruck.ProfileImage
            };
            ViewData["FoodTruckId"] = new SelectList(dbContext.Users, "Id", "Id", foodTruck.FoodTruckId);
            ViewData["FoodCategoryId"] = new SelectList(dbContext.FoodCategories, "Id", "Id", foodTruck.FoodCategoryId);
            return View(editFoodTruckViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,FoodTruck")]
        public async Task<IActionResult> Edit(EditFoodTruckViewModel model)
        {

            if (ModelState.IsValid)
            {
                FoodTruck foodTruck = await dbContext.FoodTrucks.FindAsync(model.FoodTruckId);
                foodTruck.Name = model.FoodTruckName;
                foodTruck.Bio = model.TruckBio;
                foodTruck.FoodCat = model.FoodCategory;
                foodTruck.InstagramLink = model.InstaLink;
                foodTruck.FacebookLink = model.FacebookLink;
                
                if (model.Image != null)
                {
                    //Check for existing image
                    if (model.ExistingImagePath != null)
                    {
                        string imagePath = Path.Combine(hostingEnvironment.WebRootPath, "images", model.ExistingImagePath);
                        System.IO.File.Delete(imagePath);
                    }
                    foodTruck.ProfileImage = ProcessUploadedFile(model);
                }

                dbContext.Update(foodTruck);
                await dbContext.SaveChangesAsync();

                return RedirectToAction("MyProfile", "User", new { id = model.FoodTruckId });

            }
            
            return View(model);
        }

        // GET: FoodTrucks/Delete/5
        [Authorize(Roles = "Admin,FoodTruck")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                ViewBag.ErrorMessage = $"The FoodTruck with Id = {id} cannot be found";
                return View("NotFound");
            }

            var foodTruck = await dbContext.FoodTrucks
                .Include(f => f.ApplicationUser)
                .Include(f => f.FoodCategory)
                .FirstOrDefaultAsync(m => m.FoodTruckId == id);
            if (foodTruck == null)
            {
                ViewBag.ErrorMessage = $"The FoodTruck with Id = {id} cannot be found";
                return View("NotFound");
            }

            return View(foodTruck);
        }

        // POST: FoodTrucks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,FoodTruck")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var UsersReviews = dbContext.Reviews.Where(r => r.FoodTruckId == id).ToList();
            dbContext.RemoveRange(UsersReviews);
            await dbContext.SaveChangesAsync();

            var foodTruck = await dbContext.FoodTrucks.FindAsync(id);
            dbContext.FoodTrucks.Remove(foodTruck);
            await dbContext.SaveChangesAsync();

            
            

            //Delete their truck and change them back to a standard user
            var user = await userManager.FindByIdAsync(id);
            
            var result = await userManager.RemoveFromRoleAsync(user, "FoodTruck");
            
            if (result.Succeeded)
            {
                var roleResult = await userManager.AddToRoleAsync(user, "User");
                if (roleResult.Succeeded)
                {
                    await signInManager.SignOutAsync();
                    await signInManager.SignInAsync(user, true);

                    return RedirectToAction("MyProfile", "User", new { id = user.Id });
                }
            }

            return RedirectToAction(nameof(Index));
        }

        private bool FoodTruckExists(string id)
        {
            return dbContext.FoodTrucks.Any(e => e.FoodTruckId == id);
        }
        private string ProcessUploadedFile(EditFoodTruckViewModel model)
        {
            string uniqueFileName = null;
            if (model.Image != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
