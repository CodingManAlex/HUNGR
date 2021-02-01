using HUNGR.WebApp.Data;
using HUNGR.WebApp.Models;
using HUNGR.WebApp.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly HUNGRDbContext dbContext;
        private readonly IHostingEnvironment hostingEnvironment;

        public AdministrationController(HUNGRDbContext context, IHostingEnvironment hostingEnvironment)
        {
            dbContext = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(CreateEventViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                Event newEvent = new Event
                {
                    Name = model.EventName,
                    Description = model.Description,
                    Location = model.Location,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    ImagePath = uniqueFileName
                };
                dbContext.Add(newEvent);
                await dbContext.SaveChangesAsync();

                return RedirectToAction("CreateEvent");
                //return View();

            }


            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditEvent(int id)
        {
            if (id == null)
            {
                Response.StatusCode = 404;
                return View("EventNotFound", id);
                //return NotFound();
            }
            Event eventForEditing = await dbContext.Events.FindAsync(id);
            if(eventForEditing == null)
            {
                Response.StatusCode = 404;
                return View("EventNotFound", id);
                //return NotFound();
            }
            EditEventViewModel editEventViewModel = new EditEventViewModel
            {
                Id = eventForEditing.Id,
                EventName = eventForEditing.Name,
                Description = eventForEditing.Description,
                Location = eventForEditing.Location,
                StartDate = eventForEditing.StartDate,
                EndDate = eventForEditing.EndDate,
                ExistingImagePath = eventForEditing.ImagePath
            };
            return View(editEventViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditEvent(EditEventViewModel model)
        {
            if (ModelState.IsValid)
            {
                Event currentEvent = await dbContext.Events.FindAsync(model.Id);
                currentEvent.Name = model.EventName;
                currentEvent.Description = model.Description;
                currentEvent.Location = model.Location;
                currentEvent.StartDate = model.StartDate;
                currentEvent.EndDate = model.EndDate;
                if(model.Image != null)
                {
                    //Check for existing image
                    if(model.ExistingImagePath != null)
                    {
                        string imagePath = Path.Combine(hostingEnvironment.WebRootPath, "images", model.ExistingImagePath);
                        System.IO.File.Delete(imagePath);
                    }
                    currentEvent.ImagePath = ProcessUploadedFile(model);
                }

               
                dbContext.Update(currentEvent);
                await dbContext.SaveChangesAsync();

                return RedirectToAction("createevent");

            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            Event currentEvent = await dbContext.Events.FindAsync(id);

            if(currentEvent == null)
            {
                ViewBag.ErrorMessage = $"The Event with Id = {id} cannot be found";
                return View("NotFound");
            }
            //Check for existing image
            if (currentEvent.ImagePath != null)
            {
                string imagePath = Path.Combine(hostingEnvironment.WebRootPath, "images", currentEvent.ImagePath);
                System.IO.File.Delete(imagePath);
            }

            dbContext.Events.Remove(currentEvent);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("createevent");

        }

        private string ProcessUploadedFile(CreateEventViewModel model)
        {
            string uniqueFileName = null;
            if (model.Image != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using(var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
