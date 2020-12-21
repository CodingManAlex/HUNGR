using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Models
{
    public class UserFavouriteTruck
    {
        public string FoodTruckId { get; set; }
        public FoodTruck FoodTruck { get; set; }

        public string Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
