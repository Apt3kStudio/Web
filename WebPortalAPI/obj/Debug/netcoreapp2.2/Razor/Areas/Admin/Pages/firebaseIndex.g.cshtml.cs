#pragma checksum "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c1491696537366ad450d0d48fd435fa5e8ffeb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebPortalAPI.Areas.Admin.Models.Pages.Areas_admin_Pages_firebaseIndex), @"mvc.1.0.razor-page", @"/Areas/admin/Pages/firebaseIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/admin/Pages/firebaseIndex.cshtml", typeof(WebPortalAPI.Areas.Admin.Models.Pages.Areas_admin_Pages_firebaseIndex), null)]
namespace WebPortalAPI.Areas.Admin.Models.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\_ViewImports.cshtml"
using WebPortalAPI;

#line default
#line hidden
#line 2 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\_ViewImports.cshtml"
using WebPortalAPI.Areas.admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1491696537366ad450d0d48fd435fa5e8ffeb8", @"/Areas/admin/Pages/firebaseIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e83f88b383d245ae24cc32478bc15897b67392f", @"/Areas/admin/_ViewImports.cshtml")]
    public class Areas_admin_Pages_firebaseIndex : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "firebaseCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./firebaseEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./firebaseDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./firebaseDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(59, 247, true);
            WriteLiteral("\r\n<div class=\"row \">\r\n    <div class=\"col-sm-12 firebaseContentHeader box-Shadow-light\">\r\n        <h1>Firebase Settings Management</h1>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12 addFirebaseBox\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(306, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c1491696537366ad450d0d48fd435fa5e8ffeb85032", async() => {
                BeginContext(335, 20, true);
                WriteLiteral("Add Firebase Setting");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(359, 259, true);
            WriteLiteral(@"
        </p>
    </div>
</div>
<div class=""row"">
    <div class=""col-sm-12 box-Shadow-light firebaseContentBody"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(619, 66, false);
#line 24 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirebaseSetting[0].ProfileName));

#line default
#line hidden
            EndContext();
            BeginContext(685, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(765, 68, false);
#line 27 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirebaseSetting[0].ApplicationID));

#line default
#line hidden
            EndContext();
            BeginContext(833, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(913, 63, false);
#line 30 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirebaseSetting[0].SenderID));

#line default
#line hidden
            EndContext();
            BeginContext(976, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1056, 63, false);
#line 33 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirebaseSetting[0].DeviceID));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1199, 66, false);
#line 36 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirebaseSetting[0].RequestType));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1345, 66, false);
#line 39 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirebaseSetting[0].ContentType));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1491, 65, false);
#line 42 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirebaseSetting[0].FCMSendUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1556, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 48 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                 foreach (var item in Model.FirebaseSetting)
                {

#line default
#line hidden
            BeginContext(1763, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1848, 46, false);
#line 52 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProfileName));

#line default
#line hidden
            EndContext();
            BeginContext(1894, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1986, 50, false);
#line 55 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                       Write(utility.TruncateString(item.ApplicationID, 20, 20));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2128, 43, false);
#line 58 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SenderID));

#line default
#line hidden
            EndContext();
            BeginContext(2171, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2263, 43, false);
#line 61 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DeviceID));

#line default
#line hidden
            EndContext();
            BeginContext(2306, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2398, 46, false);
#line 64 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RequestType));

#line default
#line hidden
            EndContext();
            BeginContext(2444, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2536, 46, false);
#line 67 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ContentType));

#line default
#line hidden
            EndContext();
            BeginContext(2582, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2674, 47, false);
#line 70 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                       Write(utility.TruncateString(item.FCMSendUrl, 20, 20));

#line default
#line hidden
            EndContext();
            BeginContext(2721, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2812, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c1491696537366ad450d0d48fd435fa5e8ffeb814066", async() => {
                BeginContext(2865, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                                                           WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2873, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2905, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c1491696537366ad450d0d48fd435fa5e8ffeb816464", async() => {
                BeginContext(2961, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                                                              WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2972, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(3004, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c1491696537366ad450d0d48fd435fa5e8ffeb818868", async() => {
                BeginContext(3059, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                                                             WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3069, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 78 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
                }

#line default
#line hidden
            BeginContext(3148, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
#line 84 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseIndex.cshtml"
           

    Utils utility = new Utils();

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPortalAPI.Areas.Admin.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebPortalAPI.Areas.Admin.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebPortalAPI.Areas.Admin.Pages.IndexModel>)PageContext?.ViewData;
        public WebPortalAPI.Areas.Admin.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
