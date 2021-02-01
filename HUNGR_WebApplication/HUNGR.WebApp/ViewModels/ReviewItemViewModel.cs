﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.ViewModels
{
    public class ReviewItemViewModel
    {
        public string Id { get; set; }
        public string? ProfileImage { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewBody { get; set; }
        public int ReviewRating { get; set; }
        public int Type { get; set; }
    }
}
