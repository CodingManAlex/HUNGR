#pragma checksum "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b8a42a2dd07b44e978474ab79e5a2b582d6098c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MyProfile), @"mvc.1.0.view", @"/Views/User/MyProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b8a42a2dd07b44e978474ab79e5a2b582d6098c", @"/Views/User/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0b17b632ae4033bc05948a6df94d4094ffa110", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("ProfileImage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Responsive image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FoodTrucks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
 if (Model.User.FoodTruck == null)
{
    var photoPath = "~/images/" + (Model.User.ProfileImage ?? "defaultProfileImage.png");

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b8a42a2dd07b44e978474ab79e5a2b582d6098c7197", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
          WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 11 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            <h1>");
#nullable restore
#line 14 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
           Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                                 Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <h4>");
#nullable restore
#line 17 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                   Write(Model.User.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 17 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                                     Write(Model.User.Province);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col\">\r\n            <h1>Favourite Foods</h1>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n");
#nullable restore
#line 25 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                     if (Model.User.FoodCategory != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4>");
#nullable restore
#line 27 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                       Write(Model.User.FoodCategory.GetDisplayName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 28 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4>This user has not set a favourite food.</h4>\r\n");
#nullable restore
#line 32 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
}
else
{
    var photoPath = "~/images/" + (Model.User.FoodTruck.ProfileImage ?? "defaultProfileImage.png");
    var workingState = Model.User.FoodTruck.State;

    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row mt-5\">\r\n    <div class=\"col-7\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                State : ");
#nullable restore
#line 48 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                   Write(Model.User.FoodTruck.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Lat : ");
#nullable restore
#line 49 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                 Write(Model.User.FoodTruck.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Long : ");
#nullable restore
#line 50 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                  Write(Model.User.FoodTruck.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n            \r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
                <script>
                    var workingState = 0;

                    var truckLat = 0;
                    var truckLong = 0;

                    function getLocation() {
                        var promise = new Promise(function(resolve, reject) {
                        if (navigator.geolocation) {
                            navigator.geolocation.getCurrentPosition(
                                function (position) {
                                    truckLat = position.coords.latitude;
                                    truckLong = position.coords.longitude;
                                    resolve(""Success"")
                                }
                            );
                        } else {
                          reject(""Error"");
                        }
                    });

                    return promise;
                }
                    function locationHandler(position) {
                        truckLat = position.co");
                WriteLiteral(@"ords.latitude;
                        truckLong = position.coords.longitude;
                    }

                    function OpenCloseFoodTruckAjax(truckId) {
                        var text = $(""#alertButton"").text();
                        console.log(text);
                        //This means the truck is closed
                        if (text == ""Open Truck"") {
                            console.log("" Before: Matched the button text! Open Truck"")
                            var locationPromise = getLocation();
                            locationPromise.then(function (response) {
                                console.log(response);
                                console.log(truckLat);
                                console.log(typeof truckLat.toString());
                                console.log(truckLong);
                                console.log(typeof truckLong.toString());

                                OpenCloseTruckAjax(truckId, truckLat, truckLong);
        ");
                WriteLiteral(@"                    }, function (error) {
                                console.log(""Failed!"", error);
                            })

                        } else {
                            var text2 = $(""#alertButton"").text();

                            if (text2 == ""Open Truck"") {
                                console.log(""Before: Matched the button text! Close Truck"")
                            }
                            OpenCloseTruckAjax(truckId, truckLat, truckLong)
                            console.log(""truck Lat : "" + truckLat);
                            console.log(""truck Long : "" + truckLong);
                            console.log("""")
                        }
                        

                        //console.log(text);
                        //console.log(""current state "" + truckState)

                        //If Closed, open and grab coordinates
                        //if (truckState == 0) {
                        //    navigator.geolocat");
                WriteLiteral(@"ion.getCurrentPosition(locationHandler);
                        //}

                        //if (truckState == 0) {
                        //    console.log(""State "" + truckState)
                        //    console.log(""truck Lat : "" + truckLat);
                        //    console.log(""truck Long : "" + truckLong);
                        //}
                    }

                    function OpenCloseTruckAjax(truckId, truckLat,truckLong) {
                        $.ajax({
                            type: ""POST"",
                            url: ""/FoodTrucks/OpenCloseFoodTruckAjax"",
                            data: {
                                foodTruckId: truckId,
                                foodTruckLat: truckLat,
                                foodTruckLong: truckLong
                            },
                            dataType: ""json"",
                            success: function (result) {
                                if (result == 1) {
            ");
                WriteLiteral(@"                        //$(""alertButton"").remove();
                                    //$(""buttonContainer"").html(""<button id=\""alertButton\"" class=\""btn btn-warning\"" onclick=\""OpenCloseFoodTruckAjax(""+ truckId +"",""+ result +"");\"">Close Truck</button>"" )
                                    //console.log(""Open"");
                                    $(""#alertButton"").removeClass(""btn-success"").addClass(""btn-warning"");
                                    $(""#alertButton"").html(""Close Truck"");
                                    //location.reload(true);

                                }
                                if (result == 0) {
                                    //$(""alertButton"").remove();
                                    //$(""buttonContainer"").html(""<button id=\""alertButton\"" class=\""btn btn-success\"" onclick=\""OpenCloseFoodTruckAjax("" + truckId + "","" + result + "");\"">Open Truck</button>"")
                                    //console.log(""Closed"");
                                ");
                WriteLiteral(@"    $(""#alertButton"").removeClass(""btn-warning"").addClass(""btn-success"");
                                    $(""#alertButton"").html(""Open Truck"");
                                    //location.reload(true);
                                }



                                //if (text2 == ""Close Truck"") {
                                //    console.log(""After: Matched the button text! Close Truck"")
                                //}
                            },
                            failure: function () {
                                alert(""A failure occured"");
                            },
                            error: function (response) {
                                alert(""An error occuring"")
                            }
                        });
                    }
                </script>
        ");
            }
            );
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h2>Truck Name</h2>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h1>");
#nullable restore
#line 182 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
               Write(Model.User.FoodTruck.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h2>Truck Bio</h2>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h1>");
#nullable restore
#line 192 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
               Write(Model.User.FoodTruck.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h2>Category</h2>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h1>");
#nullable restore
#line 202 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
               Write(Model.User.FoodTruck.FoodCat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral(@"            </div>
        </div>
        <div class=""row"">
            <div class=""col"">
                <h2>Social Media Links</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col"">
                <i class=""fa fa-instagram fa-2x"" aria-hidden=""true""></i>
            </div>
            <div class=""col"">
                ");
#nullable restore
#line 216 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
           Write(Model.User.FoodTruck.InstagramLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <i class=\"fa fa-facebook-square fa-2x\" aria-hidden=\"true\"></i>\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
#nullable restore
#line 224 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
           Write(Model.User.FoodTruck.FacebookLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-5\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b8a42a2dd07b44e978474ab79e5a2b582d6098c22991", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 231 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
              WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 231 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col d-flex justify-content-center\">\r\n");
#nullable restore
#line 236 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                 if (Model.User.FoodTruck.Reviews.Any() && Model.User.FoodTruck.Reviews.Count > 0)
                {
                    double sum = 0;
                    double revCount = Model.User.FoodTruck.Reviews.Count;
                    foreach (var review in Model.User.FoodTruck.Reviews)
                    {
                        sum += review.Rating;
                    }
                    double avgRating = sum / revCount;
                    avgRating = Math.Round(avgRating, 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1 class=\"display-3 d-flex justify-content-center\" id=\"foodTruckRating\">");
#nullable restore
#line 246 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                                                                                        Write(avgRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 247 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1 class=\"display-3 d-flex justify-content-center\" id=\"foodTruckRating\">NA</h1>\r\n");
#nullable restore
#line 251 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div id=\"buttonContainer\" class=\"col d-flex justify-content-center\">\r\n");
#nullable restore
#line 257 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                 if (Model.User.FoodTruck.State == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button id=\"alertButton\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 10709, "\"", 10779, 3);
            WriteAttributeValue("", 10719, "OpenCloseFoodTruckAjax(\'", 10719, 24, true);
#nullable restore
#line 259 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
WriteAttributeValue("", 10743, Model.User.FoodTruck.FoodTruckId, 10743, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10776, "\');", 10776, 3, true);
            EndWriteAttribute();
            WriteLiteral(">Open Truck</button>\r\n");
#nullable restore
#line 260 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button id=\"alertButton\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 10930, "\"", 11000, 3);
            WriteAttributeValue("", 10940, "OpenCloseFoodTruckAjax(\'", 10940, 24, true);
#nullable restore
#line 263 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
WriteAttributeValue("", 10964, Model.User.FoodTruck.FoodTruckId, 10964, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10997, "\');", 10997, 3, true);
            EndWriteAttribute();
            WriteLiteral(">Close Truck</button>\r\n");
#nullable restore
#line 264 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col d-flex justify-content-center\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b8a42a2dd07b44e978474ab79e5a2b582d6098c29558", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 270 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                                                                                           WriteLiteral(Model.User.FoodTruck.FoodTruckId);

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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 275 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row mt-5\">\r\n    <div class=\"col d-flex justify-content-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b8a42a2dd07b44e978474ab79e5a2b582d6098c32464", async() => {
                WriteLiteral("\r\n            <button type=\"submit\" class=\"nav-link btn btn-danger text-white\">Logout</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 278 "C:\Users\Alex\Documents\GitHub\HUNGR\HUNGR_WebApplication\HUNGR.WebApp\Views\User\MyProfile.cshtml"
                                                                                          WriteLiteral(Url.Action("Index", "Home", new { area = "" }));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
