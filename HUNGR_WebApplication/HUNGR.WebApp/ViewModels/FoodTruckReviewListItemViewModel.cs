using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewModels
{
    public class FoodTruckReviewListItemViewModel
    {
        public string userId { get; set; }
        public string userProfileImage { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public int rating { get; set; }
    }
}
