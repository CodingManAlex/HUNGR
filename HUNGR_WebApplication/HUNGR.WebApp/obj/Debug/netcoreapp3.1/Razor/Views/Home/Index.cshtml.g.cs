#pragma checksum "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03079eff2c952844aeed8ed957c54220724ab086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
using HUNGR.WebApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03079eff2c952844aeed8ed957c54220724ab086", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0b17b632ae4033bc05948a6df94d4094ffa110", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OpenTrucksViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100 eventThumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FoodTrucks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
 if ((await authorizationSerivce.AuthorizeAsync(User, "UserPolicy")).Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>You\'re a Standard User</h1>\r\n");
#nullable restore
#line 15 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
 if ((await authorizationSerivce.AuthorizeAsync(User, "OwnerPolicy")).Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>You\'re A FoodTruck Owner</h1>\r\n");
#nullable restore
#line 20 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<h1>Events</h1>\r\n<div>\r\n    ");
#nullable restore
#line 28 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("CarouselEvents"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<h1 class=\"mt-5\">Who\'s Open</h1>\r\n\r\n<div class=\"card-deck\">\r\n");
#nullable restore
#line 34 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
     foreach (var truck in Model)
    {
        var photoPath = "~/images/" + (truck.ImagePath ?? "defaultProfileImage.png");

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-3\" style=\"min-width: 18rem; max-width:30.5%\">\r\n");
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03079eff2c952844aeed8ed957c54220724ab0867085", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "03079eff2c952844aeed8ed957c54220724ab0867356", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
                                                   WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1288, truck.TruckName, 1288, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 41 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
                                                                  WriteLiteral(truck.FoodTruckId);

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
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n\r\n                <div class=\"row \">\r\n                    <div class=\"col d-flex justify-content-start\">\r\n                        <h3>");
#nullable restore
#line 47 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
                       Write(truck.TruckName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"col d-flex justify-content-end\">\r\n");
#nullable restore
#line 50 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
                         if (truck.isFavourite == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-heart fa-2x\" style=\"color:red\"></i>\r\n");
#nullable restore
#line 53 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"far fa fa-heart-o fa-2x\" style=\"color:red\"></i>\r\n");
#nullable restore
#line 57 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 62 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService authorizationSerivce { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OpenTrucksViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
