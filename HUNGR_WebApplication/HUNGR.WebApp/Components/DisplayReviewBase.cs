using HUNGR.WebApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Components
{
    public class DisplayReviewBase : ComponentBase
    {
        [Parameter]
        public Review Review { get; set; }
    }
}
