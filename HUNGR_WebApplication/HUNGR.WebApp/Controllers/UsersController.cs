using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUNGR.WebApp.Data;
using HUNGR.WebApp.Models;
using HUNGR.WebApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HUNGR.WebApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly HUNGRDbContext dbContext;

        public UsersController(UserManager<ApplicationUser> userManager, HUNGRDbContext context)
        {
            this.userManager = userManager;
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UserProfile(string userId)
        {
            var id = userId;
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            var reviews = dbContext.Reviews.Where(r => r.UserId == userId).ToList();

            var model = new UserProfileViewModel
            {
                UserId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                City = user.City,
                Province = user.Province,
                Reviews = reviews
            };

            return View(model);
        }
    }
}
