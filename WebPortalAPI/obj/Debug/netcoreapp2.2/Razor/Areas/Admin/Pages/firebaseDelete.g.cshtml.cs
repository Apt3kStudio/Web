#pragma checksum "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d00b929c0b0dea075a6b4536f8fc62be000b5b7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebPortalAPI.Areas.Admin.Models.Pages.Areas_admin_Pages_firebaseDelete), @"mvc.1.0.razor-page", @"/Areas/admin/Pages/firebaseDelete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/admin/Pages/firebaseDelete.cshtml", typeof(WebPortalAPI.Areas.Admin.Models.Pages.Areas_admin_Pages_firebaseDelete), @"firebaseDelete")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "firebaseDelete")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d00b929c0b0dea075a6b4536f8fc62be000b5b7d", @"/Areas/admin/Pages/firebaseDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e83f88b383d245ae24cc32478bc15897b67392f", @"/Areas/admin/_ViewImports.cshtml")]
    public class Areas_admin_Pages_firebaseDelete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./firebaseIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 482, true);
            WriteLiteral(@"

<div class=""row "">
    <div class=""col-sm-12 firebaseContentHeader box-Shadow-light"">
        <h1>Firebase Settings Management</h1>
    </div>
</div>

<div class=""row"">
    <div class=""col-sm-12 deleteFirebaseHSubHeaderBox"">
        <h3>Are you sure you want to delete this?</h3>
    </div>
</div>
<div class=""row"">
    <div class=""col-sm-12 addFirebaseBox box-Shadow-light firebaseDetailsbox"">
        <dl class=""dl-horizontal"">
            <dt>
                ");
            EndContext();
            BeginContext(558, 63, false);
#line 20 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirebaseSetting.ProfileName));

#line default
#line hidden
            EndContext();
            BeginContext(621, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(677, 59, false);
#line 23 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayFor(model => model.FirebaseSetting.ProfileName));

#line default
#line hidden
            EndContext();
            BeginContext(736, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(792, 65, false);
#line 26 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirebaseSetting.ApplicationID));

#line default
#line hidden
            EndContext();
            BeginContext(857, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(913, 61, false);
#line 29 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayFor(model => model.FirebaseSetting.ApplicationID));

#line default
#line hidden
            EndContext();
            BeginContext(974, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1030, 60, false);
#line 32 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirebaseSetting.SenderID));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1146, 56, false);
#line 35 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayFor(model => model.FirebaseSetting.SenderID));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1258, 60, false);
#line 38 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirebaseSetting.DeviceID));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1374, 56, false);
#line 41 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayFor(model => model.FirebaseSetting.DeviceID));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1486, 63, false);
#line 44 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirebaseSetting.RequestType));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1605, 59, false);
#line 47 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayFor(model => model.FirebaseSetting.RequestType));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1720, 63, false);
#line 50 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirebaseSetting.ContentType));

#line default
#line hidden
            EndContext();
            BeginContext(1783, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1839, 59, false);
#line 53 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayFor(model => model.FirebaseSetting.ContentType));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1954, 62, false);
#line 56 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirebaseSetting.FCMSendUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2072, 58, false);
#line 59 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
           Write(Html.DisplayFor(model => model.FirebaseSetting.FCMSendUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2130, 56, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(2186, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d00b929c0b0dea075a6b4536f8fc62be000b5b7d11813", async() => {
                BeginContext(2206, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2212, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d00b929c0b0dea075a6b4536f8fc62be000b5b7d12201", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\Nelson Vasquez\Documents\Apartment3k\Web\WebPortalAPI\Areas\admin\Pages\firebaseDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirebaseSetting.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2264, 76, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\"  /> |\r\n    ");
                EndContext();
                BeginContext(2340, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d00b929c0b0dea075a6b4536f8fc62be000b5b7d14139", async() => {
                    BeginContext(2370, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2386, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2395, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPortalAPI.Areas.Admin.Pages.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebPortalAPI.Areas.Admin.Pages.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebPortalAPI.Areas.Admin.Pages.DeleteModel>)PageContext?.ViewData;
        public WebPortalAPI.Areas.Admin.Pages.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
