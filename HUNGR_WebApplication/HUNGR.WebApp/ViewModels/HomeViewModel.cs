using HUNGR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewModels
{
    public class HomeViewModel
    {
        public IQueryable<FoodTruck> FoodTrucks { get; set; }
        public string SearchTerm { get; set; }
    }
}
