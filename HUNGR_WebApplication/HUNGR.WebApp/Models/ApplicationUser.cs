using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static HUNGR.WebApp.Models.FoodEnum;

namespace HUNGR.WebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public FoodCat? FoodCategory { get; set; }
        public string? ProfileImage { get; set; }
        
        //Navigation
        public virtual FoodTruck FoodTruck { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public ICollection<UserFavouriteTruck> UserFavouriteTrucks { get; set; }
        public ICollection<UserFavouriteFood> UserFavouriteFoods { get; set; }
    }
}
