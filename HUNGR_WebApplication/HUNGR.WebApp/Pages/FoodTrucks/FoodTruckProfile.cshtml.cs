using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUNGR.WebApp.Data;
using HUNGR.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HUNGR.WebApp.Pages.FoodTrucks
{
    public class FoodTruckProfileModel : PageModel
    {

        private readonly HUNGRDbContext dbContext;

        public FoodTruckProfileModel(HUNGRDbContext context)
        {
            dbContext = context;
        }

        public FoodTruck FoodTruck { get; set; }
        public Review Review { get; set; }



        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return RedirectToPage("NotFound");
            }

            FoodTruck = await dbContext.FoodTrucks
                .Include(f => f.ApplicationUser)
                .Include(f => f.FoodCategory)
                .Include(f => f.Reviews)
                .FirstOrDefaultAsync(m => m.FoodTruckId == id);
            if (FoodTruck == null)
            {
                return RedirectToPage("NotFound");
            }

            return Page();

            //FoodTruck = await GetFoodTruck(id);
        }


        public async Task<IActionResult> GetFoodTruck(string id)
        {
            if (id == null)
            {
                return RedirectToPage("NotFound");
            }

            FoodTruck = await dbContext.FoodTrucks
                .Include(f => f.ApplicationUser)
                .Include(f => f.FoodCategory)
                .Include(f => f.Reviews)
                .FirstOrDefaultAsync(m => m.FoodTruckId == id);
            if (FoodTruck == null)
            {
                return RedirectToPage("NotFound");
            }

            return Page();
        }
    }
}
