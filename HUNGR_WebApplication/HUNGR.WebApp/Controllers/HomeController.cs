using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HUNGR.WebApp.Models;
using HUNGR.WebApp.Data;

namespace HUNGR.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HUNGRDbContext context;

        public HomeController(ILogger<HomeController> logger, HUNGRDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult Index()
        {
            var openTrucks = context.FoodTrucks.Where(f => f.State == 1).ToList();
            return View(openTrucks);
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
