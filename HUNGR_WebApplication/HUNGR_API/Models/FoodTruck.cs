using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HUNGR.API.Models
{
    public class FoodTruck 
    {
        [ForeignKey("ApplicationUser")]
        public int FoodTruckId { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public int State { get; set; }
        public string? ProfileImage { get; set; }
        public int Licence { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string? InstagramLink { get; set; }
        public string? FacebookLink { get; set; }

        public int FoodCategoryId { get; set; }
        public FoodCategory FoodCategory { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        //Joins
        public ICollection<EventParticipant> EventParticipants { get; set; }
        public ICollection<UserFavouriteTruck> UserFavouriteTrucks { get; set; }
    }
}
