using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.API.Models
{
    public class FoodCategory
    {
        public int Id{ get; set; }
        public string FoodType { get; set; }

        public virtual ICollection<FoodTruck> FoodTrucks { get; set; }

        public ICollection<UserFavouriteFood> UserFavouriteFoods { get; set; }
    }
}
