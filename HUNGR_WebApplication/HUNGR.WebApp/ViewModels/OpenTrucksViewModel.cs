using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewModels
{
    public class OpenTrucksViewModel
    {
        public string FoodTruckId { get; set; }
        public string TruckName { get; set; }
        public string ImagePath { get; set; }
        public bool isFavourite { get; set; }
    }
}
