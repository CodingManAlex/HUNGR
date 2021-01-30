using HUNGR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HUNGR.WebApp.Models.FoodEnum;

namespace HUNGR.WebApp.ViewModels
{
    public class UserProfileViewModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public FoodCat FoodCat { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public List<FoodTruck> FavouriteTrucks { get; set; }
        //public ICollection<UserFavouriteTruck> UserFavouriteTrucks { get; set; }
        //public ICollection<UserFavouriteFood> UserFavouriteFoods { get; set; }
    }
}
