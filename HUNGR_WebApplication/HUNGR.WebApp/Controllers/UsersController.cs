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
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly HUNGRDbContext dbContext;

        public UsersController(UserManager<ApplicationUser> userManager, HUNGRDbContext context)
        {
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
    }
}
