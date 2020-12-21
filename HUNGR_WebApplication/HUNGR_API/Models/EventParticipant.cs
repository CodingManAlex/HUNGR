using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.API.Models
{
    public class EventParticipant
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int FoodTruckId { get; set; }
        public FoodTruck FoodTruck { get; set; }
    }
}
