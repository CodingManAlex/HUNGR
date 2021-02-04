using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static HUNGR.WebApp.Models.FoodEnum;

namespace HUNGR.WebApp.Models
{
    public class FoodTruck
    {
        [Key,ForeignKey("ApplicationUser")]
        public string FoodTruckId { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "Name cannot be greater than 150 characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(350, ErrorMessage = "Bio cannot be greater than 3500 characters")]
        public string Bio { get; set; }
        public int State { get; set; }
        public string? ProfileImage { get; set; } //relative path to image - local repo
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string? InstagramLink { get; set; }
        public string? FacebookLink { get; set; }
        [Required]
        public FoodCat FoodCat { get; set; }

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
