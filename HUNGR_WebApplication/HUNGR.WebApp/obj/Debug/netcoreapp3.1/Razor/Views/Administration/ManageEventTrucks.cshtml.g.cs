#pragma checksum "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3b287bac4535610a042a468a453367bb719bd23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ManageEventTrucks), @"mvc.1.0.view", @"/Views/Administration/ManageEventTrucks.cshtml")]
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
#line 1 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
using HUNGR.WebApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b287bac4535610a042a468a453367bb719bd23", @"/Views/Administration/ManageEventTrucks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0b17b632ae4033bc05948a6df94d4094ffa110", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ManageEventTrucks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ManageEventTrucksViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
  
    var eventId = ViewBag.eventId;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit An Event</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label>Event Name</label>\r\n            <h5>");
#nullable restore
#line 17 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
           Write(Model.EventDetails.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Description</label>\r\n            <h5>");
#nullable restore
#line 21 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
           Write(Model.EventDetails.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Location</label>\r\n            <h5>");
#nullable restore
#line 25 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
           Write(Model.EventDetails.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n");
#nullable restore
#line 30 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
                     if (Model.EventDetails.StartDate == Model.EventDetails.EndDate)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label> Event Date</label>\r\n                        <h5>");
#nullable restore
#line 33 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
                       Write(Model.EventDetails.StartDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 34 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label> Event Dates</label>\r\n                        <h5>");
#nullable restore
#line 38 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
                       Write(Model.EventDetails.StartDate.ToString("M"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 38 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
                                                                     Write(Model.EventDetails.EndDate.ToString("d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 39 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 43 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
          
            var photoPath = "~/images/" + (Model.EventDetails.ImagePath ?? "defaultProfileImage.png");
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\" row col-sm-4 offset-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3b287bac4535610a042a468a453367bb719bd2311009", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
          WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 47 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
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
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"col-md-4 offset-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3b287bac4535610a042a468a453367bb719bd2313263", async() => {
                WriteLiteral("\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <h3>List of trucks for ");
#nullable restore
#line 55 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
                                      Write(Model.EventDetails.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 58 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
                     for (int i = 0; i < Model.EventTrucks.Count; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-check m-1\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3b287bac4535610a042a468a453367bb719bd2314446", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 61 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.EventTrucks[i].FoodTruckId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3b287bac4535610a042a468a453367bb719bd2316231", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 62 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.EventTrucks[i].FoodTruckName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3b287bac4535610a042a468a453367bb719bd2318018", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 63 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.EventTrucks[i].isSelected);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3b287bac4535610a042a468a453367bb719bd2319673", async() => {
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 65 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
                           Write(Model.EventTrucks[i].FoodTruckName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 64 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.EventTrucks[i].isSelected);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 68 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"card-footer\">\r\n                    <input type=\"submit\" class=\"btn btn-success\" value=\"Update\" style=\"width:auto;\" />\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3b287bac4535610a042a468a453367bb719bd2322218", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <hr>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 82 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\Administration\ManageEventTrucks.cshtml"
   Write(await Component.InvokeAsync("CurrentEvents"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManageEventTrucksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
