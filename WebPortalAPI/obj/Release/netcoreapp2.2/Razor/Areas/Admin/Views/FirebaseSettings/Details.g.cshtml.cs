#pragma checksum "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "436f91c0222a1c7d8a59e0ab497e367cacf544a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_FirebaseSettings_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/FirebaseSettings/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/FirebaseSettings/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_FirebaseSettings_Details))]
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
#line 1 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\_ViewImports.cshtml"
using WebPortalAPI;

#line default
#line hidden
#line 2 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\_ViewImports.cshtml"
using WebPortalAPI.Areas.admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436f91c0222a1c7d8a59e0ab497e367cacf544a6", @"/Areas/Admin/Views/FirebaseSettings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca584cc449253ed90655d8b8ebb994f686b9fee", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_FirebaseSettings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebPortalAPI.Data.FirebaseSetting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 129, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>FirebaseSetting</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(217, 47, false);
#line 14 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProfileName));

#line default
#line hidden
            EndContext();
            BeginContext(264, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(308, 43, false);
#line 17 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProfileName));

#line default
#line hidden
            EndContext();
            BeginContext(351, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(395, 49, false);
#line 20 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationID));

#line default
#line hidden
            EndContext();
            BeginContext(444, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(488, 45, false);
#line 23 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationID));

#line default
#line hidden
            EndContext();
            BeginContext(533, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(577, 44, false);
#line 26 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SenderID));

#line default
#line hidden
            EndContext();
            BeginContext(621, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(665, 40, false);
#line 29 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.SenderID));

#line default
#line hidden
            EndContext();
            BeginContext(705, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(749, 44, false);
#line 32 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeviceID));

#line default
#line hidden
            EndContext();
            BeginContext(793, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(837, 40, false);
#line 35 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeviceID));

#line default
#line hidden
            EndContext();
            BeginContext(877, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(921, 47, false);
#line 38 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestType));

#line default
#line hidden
            EndContext();
            BeginContext(968, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1012, 43, false);
#line 41 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestType));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1099, 47, false);
#line 44 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContentType));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1190, 43, false);
#line 47 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContentType));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1277, 46, false);
#line 50 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FCMSendUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1367, 42, false);
#line 53 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.FCMSendUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1456, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "436f91c0222a1c7d8a59e0ab497e367cacf544a610568", async() => {
                BeginContext(1502, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 58 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\FirebaseSettings\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(1510, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1518, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "436f91c0222a1c7d8a59e0ab497e367cacf544a612920", async() => {
                BeginContext(1540, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(1556, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPortalAPI.Data.FirebaseSetting> Html { get; private set; }
    }
}
#pragma warning restore 1591
