#pragma checksum "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a70dcfeedd246ed951c758c997559bee56de0de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebPortalAPI.Areas.Admin.Pages.Shared.Areas_Admin_Views_Shared_Error), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Error.cshtml", typeof(WebPortalAPI.Areas.Admin.Pages.Shared.Areas_Admin_Views_Shared_Error))]
namespace WebPortalAPI.Areas.Admin.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a70dcfeedd246ed951c758c997559bee56de0de", @"/Areas/Admin/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757897e5084e1b17349c208671224a61b0753e95", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebPortalAPI.Areas.admin.Models.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(96, 120, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(246, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(299, 15, false);
#line 12 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(314, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Users\Diosc\Documents\Repos\APT3KStudio\Web\WebPortalAPI\Areas\Admin\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(336, 562, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPortalAPI.Areas.admin.Models.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
