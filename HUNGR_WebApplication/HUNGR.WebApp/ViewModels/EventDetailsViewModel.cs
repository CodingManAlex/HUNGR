using HUNGR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewModels
{
    public class EventDetailsViewModel
    {
        public Event EventDetails { get; set; }
        public List<FoodTruck> EventFoodTrucks { get; set; }
    }
}
