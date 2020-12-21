using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.API.Models
{
    public class StandardUserProfile 
    //public class StandardUserProfile : IdentityUser
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public virtual List<Review> Reviews { get; set; }
        //public virtual List<FoodCategory> FavouriteFoods { get; set; }
        
        public Boolean hasFoodTruck { get; set; }
        
        public FoodTruck? FoodTruck { get; set; }
        
        public ICollection<UserFavouriteTruck> UserFavouriteTrucks { get; set; }
        public ICollection<UserFavouriteFood> UserFavouriteFoods { get; set; }
    }
}
