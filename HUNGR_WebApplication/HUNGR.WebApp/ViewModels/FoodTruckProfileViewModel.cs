using HUNGR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewModels
{
    public class FoodTruckProfileViewModel 
    {

        public FoodTruck FoodTruckModel { get; set; }
        public Review FoodTruckReview { get; set; }
        public UserFavouriteTruck UserFoodTruckLike { get; set; }
        //public string ReviewTruckId { get; set; }
        //public string ReviewUserId { get; set; }
        //public string ReviewTitle { get; set; }
        //public string ReviewBody { get; set; }
        //public int ReviewRating { get; set; }
    }
}
