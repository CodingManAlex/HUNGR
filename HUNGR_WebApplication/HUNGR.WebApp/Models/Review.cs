using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Rating { get; set; }

        //Foreign Key - Who made the review
        public string? UserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }

        //Foreign Key - For which truck the review was made
        public string FoodTruckId { get; set; }
        public virtual FoodTruck FoodTruck { get; set; }

        
    }
}
