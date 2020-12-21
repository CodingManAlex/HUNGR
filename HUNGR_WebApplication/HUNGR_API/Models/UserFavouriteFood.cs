using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.API.Models
{
    public class UserFavouriteFood
    {
        public int FoodCategoryId { get; set; }
        public FoodCategory FoodCategory { get; set; }

        public int UserId { get; set; }
        public StandardUserProfile StandardUserProfile { get; set; }
    }
}
