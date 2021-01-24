using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUNGR.WebApp.Data;
using HUNGR.WebApp.Models;
using HUNGR.WebApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HUNGR.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly HUNGRDbContext dbContext;

        public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, HUNGRDbContext context)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UserProfile(string userId)
        {
            var id = userId;
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            var reviews = dbContext.Reviews.Where(r => r.UserId == userId).ToList();

            var favTrucksId = dbContext.UserFavouriteTrucks.Where(ft => ft.Id == userId).ToList();
            var listOfFoodTrucks = new List<FoodTruck>();
            
            foreach(var truckId in favTrucksId)
            {
                var foodTruck = await dbContext.FoodTrucks
                .FirstOrDefaultAsync(m => m.FoodTruckId == truckId.FoodTruckId);

                listOfFoodTrucks.Add(foodTruck);
            }

            var model = new UserProfileViewModel
            {
                UserId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                City = user.City,
                Province = user.Province,
                Reviews = reviews,
                FavouriteTrucks = listOfFoodTrucks
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
            //string userId = User.FindFirst("UserId").Value;
            //Get Basic User Info
            ApplicationUser UserProfile = await userManager.FindByIdAsync(User.FindFirst("UserId").Value);

            FoodTruck foodTruck = await dbContext.FoodTrucks
                .Include(f => f.ApplicationUser)
                .Include(f => f.FoodCategory)
                .Include(f => f.Reviews)
                .Include(f => f.UserFavouriteTrucks)
                .FirstOrDefaultAsync(m => m.FoodTruckId == UserProfile.Id);

            var model = new MyProfileViewModel
            {
                User = UserProfile
            };

            if(foodTruck == null)
            {
                return View(model);
            }
            model.User.FoodTruck = foodTruck;

            return View(model);
        }
    }
}
