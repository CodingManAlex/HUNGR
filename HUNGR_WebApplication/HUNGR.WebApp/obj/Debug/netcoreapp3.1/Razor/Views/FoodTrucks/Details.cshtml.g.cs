#pragma checksum "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd3ba1b8e57e38009a1a9182bde2c5c1e803956c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FoodTrucks_Details), @"mvc.1.0.view", @"/Views/FoodTrucks/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\_ViewImports.cshtml"
using HUNGR.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\_ViewImports.cshtml"
using HUNGR.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\_ViewImports.cshtml"
using HUNGR.WebApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd3ba1b8e57e38009a1a9182bde2c5c1e803956c", @"/Views/FoodTrucks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0b17b632ae4033bc05948a6df94d4094ffa110", @"/Views/_ViewImports.cshtml")]
    public class Views_FoodTrucks_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HUNGR.WebApp.Models.FoodTruck>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>FoodTruck</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProfileImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProfileImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InstagramLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayFor(model => model.InstagramLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FacebookLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayFor(model => model.FacebookLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationUser.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FoodCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
       Write(Html.DisplayFor(model => model.FoodCategory.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3ba1b8e57e38009a1a9182bde2c5c1e803956c11301", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\FoodTrucks\Details.cshtml"
                           WriteLiteral(Model.FoodTruckId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3ba1b8e57e38009a1a9182bde2c5c1e803956c13476", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HUNGR.WebApp.Models.FoodTruck> Html { get; private set; }
    }
}
#pragma warning restore 1591
