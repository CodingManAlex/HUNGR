using HUNGR.WebApp.Data;
using HUNGR.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewComponents
{
    public class CreateReviewViewComponent : ViewComponent
    {
        private readonly HUNGRDbContext dbContext;

        public CreateReviewViewComponent(HUNGRDbContext context)
        {
            dbContext = context;
        }

        public IViewComponentResult Invoke(String foodTruckId, String userId)
        {
            ViewData["FoodTruckId"] = foodTruckId;
            ViewData["UserId"] = userId;
            //Review review = new Review {
            //    FoodTruckId = foodTruckId,
            //    UserId = userId
            //};
            return View("Default");
        }

        //[HttpGet]
        //public IActionResult CreateEvent(String foodTruckId, String userId)
        //{
        //    ViewData["FoodTruckId"] = foodTruckId;
        //    ViewData["UserId"] = userId;
        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateReview(Review review)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(review);
                await dbContext.SaveChangesAsync();
                return (IActionResult)View("profile", review.FoodTruckId);
            }
            //ViewData["Id"] = review.Id;
            //ViewData["FoodTruckId"] = review.FoodTruckId;
            return (IActionResult)View("profile", review.FoodTruckId);
        }
    }
}
