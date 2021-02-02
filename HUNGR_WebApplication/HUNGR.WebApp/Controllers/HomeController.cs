using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HUNGR.WebApp.Models;
using HUNGR.WebApp.Data;
using Microsoft.EntityFrameworkCore;
using HUNGR.WebApp.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace HUNGR.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HUNGRDbContext context;
        private readonly SignInManager<ApplicationUser> signInManager;

        public HomeController(SignInManager<ApplicationUser> signInManager, ILogger<HomeController> logger, HUNGRDbContext context)
        {
            _logger = logger;
            this.context = context;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchTerm)
        {
            ViewData["SearchFoodTruckDetails"] = searchTerm;
            ViewBag.SearchTerm = searchTerm;
            //var query = from x in context.FoodTrucks select x;


            if (String.IsNullOrEmpty(searchTerm))
            {
                return View(await context.FoodTrucks.ToListAsync());
            }
            //var query = context.FoodTrucks.Include(f => f.FoodCat ).Where(f => f.Name.Contains(searchTerm) );

            //var query = context.FoodTrucks.Where(f => f.FoodCat.ToString) );
            //if(query.Count() == 1)
            //{
            //    RedirectToAction("profile", "foodtrucks", query.First().FoodTruckId);
            //}
            return View(context.FoodTrucks.Where(f => f.Name.Contains(searchTerm)).ToList());
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}



        public async Task<ViewResult> IndexAsync()
        {
            //List of open truck based on view model
            List<OpenTrucksViewModel> openTrucksList = new List<OpenTrucksViewModel>();
            
            //Query Open Trucks
            var openTrucks = context.FoodTrucks.Where(f => f.State == 1).ToList();

            //Create new truck models
            foreach (var truck in openTrucks)
            {
                openTrucksList.Add(new OpenTrucksViewModel
                {
                    FoodTruckId = truck.FoodTruckId,
                    TruckName = truck.Name,
                    ImagePath = truck.ProfileImage,
                    isFavourite = false
                });
            }


            //If user is logged in
            if (signInManager.IsSignedIn(User) && User.IsInRole("User"))
            {
                //Logged In User Id
                string userId = User.FindFirst("UserId").Value;

                //Query Favourites List Based off of User Id
                var favTruckList = context.UserFavouriteTrucks.Where(e => e.Id == userId).ToList();
                int favCount = favTruckList.Count(); //Grab Count
                
                //List<OpenTrucksViewModel> favOpenTrucks = new List<OpenTrucksViewModel>();

                

                //If there are favourites
                if (favCount > 0)
                {

                    var favTrucks = openTrucksList.Where(truck => favTruckList.Select(fav => fav.FoodTruckId).Contains(truck.FoodTruckId)).ToList();
                    var notFavTrucks = openTrucksList.Where(truck => !favTruckList.Select(fav => fav.FoodTruckId).Contains(truck.FoodTruckId)).ToList();
                    
                    //var reOrderedTrucks = openTrucks.OrderBy( t =>t.FoodTruckId ).Select( i => new FoodTruck {  })
                    var allOpenTrucks = favTrucks.Concat(notFavTrucks).ToList();

                    for (int i = 0; i < favCount; i++)
                    {
                        allOpenTrucks[i].isFavourite = true;
                    }

                    return View(allOpenTrucks);
                }
                else //No Favourites
                {
                    return View(openTrucksList);
                }

            }
            else
            {
                return View(openTrucksList);
            }




            //var test = context.FoodTrucks.Join(context.UserFavouriteTrucks,
            //    ft => ft.FoodTruckId,
            //    fav => fav.FoodTruckId,
            //    (ft,fav)=> new
            //    {

            //    }
            //    )
            //foreach(var entry in favTruckList)
            //{
            //    var truck = await context.FoodTrucks.FindAsync(entry.FoodTruckId);
            //    if (truck.State == 1)
            //    {
            //        favOpenTrucks.Add(new OpenTrucksViewModel { 
            //            FoodTruckId = truck.FoodTruckId,
            //            TruckName = truck.Name,
            //            ImagePath = truck.ProfileImage,
            //            isFavourite = true
            //        });
            //    }
            //}
            //foreach(var fav in favTrucks )
            //{
            //    foreach(var truck in openTrucks)
            //    {
            //        if (fav.FoodTruckId.Equals(truck.FoodTruckId))
            //        {

            //        }
            //    }
            //}

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //[HttpGet]
        //public IActionResult ListOpenTrucks()
        //{
        //    var openTrucks = context.FoodTrucks.Where(f => f.State == 1).ToList();
        //    return View(openTrucks);
        //}
    }
}
