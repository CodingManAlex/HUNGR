using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Models
{
    public class FoodTruck
    {
        [Key,ForeignKey("ApplicationUser")]
        public string FoodTruckId { get; set; }
        public string Name { get; set; }
        public string? Bio { get; set; }
        public int State { get; set; }
        public string? ProfileImage { get; set; } //relative path to image - local repo
        public int? Licence { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string? InstagramLink { get; set; }
        public string? FacebookLink { get; set; }
        public FoodCat? FoodCat { get; set; }

        //Navigation
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string? FoodCategoryId { get; set; }
        public FoodCategory FoodCategory { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        //Joins
        public ICollection<EventParticipant> EventParticipants { get; set; }
        public ICollection<UserFavouriteTruck> UserFavouriteTrucks { get; set; }

    }
}
