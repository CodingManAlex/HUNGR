using HUNGR.WebApp.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static HUNGR.WebApp.Models.FoodEnum;

namespace HUNGR.WebApp.ViewModels
{
    public class EditFoodTruckViewModel
    {
        public string FoodTruckId { get; set; }
        [Display(Name ="Truck Name")]
        [Required]
        [MinLength(1, ErrorMessage = "Name must be at least 1 character")]
        [MaxLength(150, ErrorMessage = "Name cannot be greater than 150 characters")]
        public string FoodTruckName { get; set; }
        [Display(Name = "Truck Bio")]
        [Required]
        [MinLength(1, ErrorMessage = "Bio must be at least 1 character")]
        [MaxLength(350, ErrorMessage = "Bio cannot be greater than 350 characters")]
        public string TruckBio { get; set; }
        [Display(Name = "Category")]
        public FoodCat FoodCategory { get; set; }
        public string InstaLink { get; set; }
        public string FacebookLink { get; set; }
        public IFormFile Image { get; set; }
        public string ExistingImagePath { get; set; }
    }
}
