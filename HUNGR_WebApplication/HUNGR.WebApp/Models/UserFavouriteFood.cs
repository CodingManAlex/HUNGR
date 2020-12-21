using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Models
{
    public class UserFavouriteFood
    {
        public string FoodCategoryId { get; set; }
        public FoodCategory FoodCategory { get; set; }

        public string Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
