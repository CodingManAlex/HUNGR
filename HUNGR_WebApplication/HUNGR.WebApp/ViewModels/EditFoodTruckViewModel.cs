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
        public string FoodTruckName { get; set; }
        [Display(Name = "Truck Bio")]
        public string TruckBio { get; set; }
        [Display(Name = "Category")]
        public FoodCat FoodCategory { get; set; }
        public string InstaLink { get; set; }
        public string FacebookLink { get; set; }
        public IFormFile Image { get; set; }
        public string ExistingImagePath { get; set; }
    }
}
