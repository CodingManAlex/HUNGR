using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Models
{
    public class Review
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Rating { get; set; }

        public string? FoodTruckId { get; set; }
        public FoodTruck FoodTruck { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
