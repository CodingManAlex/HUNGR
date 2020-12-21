using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.API.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Rating { get; set; }

        public int? FoodTruckId { get; set; }
        public FoodTruck FoodTruck { get; set; }
        
        public int? UserId { get; set; }
        public StandardUserProfile StandardUserProfile { get; set; }
    }
}
