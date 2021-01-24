using HUNGR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewModels
{
    public class MyProfileViewModel
    {
        public ApplicationUser User { get; set; }
        public string FoodTruckId { get; set; }
    }
}
