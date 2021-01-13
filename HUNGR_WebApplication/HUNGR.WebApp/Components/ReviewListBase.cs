using HUNGR.WebApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Components
{
    public class ReviewListBase : ComponentBase
    {
        [Parameter]
        public List<Review> TruckReviews { get; set; }

        //protected override Task OnInitializedAsync()
        //{
        //    return base.OnInitializedAsync();
        //}

        public void GetReviews(List<Review> reviews)
        {
            TruckReviews = reviews;
        }

        
    }
}
