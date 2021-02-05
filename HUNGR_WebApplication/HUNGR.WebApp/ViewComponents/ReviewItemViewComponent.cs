using HUNGR.WebApp.Controllers;
using HUNGR.WebApp.Data;
using HUNGR.WebApp.Models;
using HUNGR.WebApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewComponents
{
    public class ReviewItemViewComponent : ViewComponent
    {
        private readonly HUNGRDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public ReviewItemViewComponent(HUNGRDbContext context, UserManager<ApplicationUser> userManager)
        {
                dbContext = context;
            this.userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id, string title, string body, int rating, int type)
        {
            if(type == 1)   //For FoodTruckPage
            {
                //Get the users profile photo
                var user = await userManager.FindByIdAsync(id);

                var review = new ReviewItemViewModel()
                {
                   Id = id,
                   ReviewTitle = title,
                   ReviewBody = body,
                   ReviewRating = rating,
                   ProfileImage = user.ProfileImage,
                   Type = type
                };

                return View(review);
            }
            if(type == 2)
            {
                var foodTruck = await dbContext.FoodTrucks.FindAsync(id);
                var review = new ReviewItemViewModel()
                {
                    Id = id,
                    ReviewTitle = title,
                    ReviewBody = body,
                    ReviewRating = rating,
                    ProfileImage = foodTruck.ProfileImage,
                    Type = type
                };

                return View(review);
            }
            return View();

        }

    }
}
