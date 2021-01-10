using HUNGR.WebApp.Controllers;
using HUNGR.WebApp.Data;
using HUNGR.WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewComponents
{
    public class CarouselEventsViewComponent : ViewComponent
    {
        private readonly HUNGRDbContext dbContext;

        public CarouselEventsViewComponent(HUNGRDbContext context)
        {
                dbContext = context;
        }

        public IViewComponentResult Invoke()
        {
            var result = dbContext.Events.Select(e => new CurrentEventViewModel()
            {
                EventId = e.Id,
                Name = e.Name,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
                ImagePath = e.ImagePath
            }).ToList();

            return View(result);
        }

    }
}
