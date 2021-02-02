using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewModels
{
    public class EditEventViewModel : CreateEventViewModel
    {
        public int? Id { get; set; }
        public string ExistingImagePath { get; set; }
    }
}
