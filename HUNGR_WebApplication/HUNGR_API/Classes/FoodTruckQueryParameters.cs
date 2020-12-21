using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.API.Classes
{
    public class FoodTruckQueryParameters : QueryParameters
    {
        public int? State  { get; set; }
        public string Name { get; set; }
    }
}
