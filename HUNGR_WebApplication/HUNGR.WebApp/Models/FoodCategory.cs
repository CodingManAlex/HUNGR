using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Models
{
    public class FoodCategory
    {
        public string Id { get; set; }
        public string FoodType { get; set; }

        public virtual ICollection<FoodTruck> FoodTrucks { get; set; }

        public ICollection<UserFavouriteFood> UserFavouriteFoods { get; set; }
    }
}
