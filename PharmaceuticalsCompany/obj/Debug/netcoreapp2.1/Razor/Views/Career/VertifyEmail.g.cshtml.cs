#pragma checksum "D:\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Career\VertifyEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a803fe3883ae00272a4251c6186253e24cf4c6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Career_VertifyEmail), @"mvc.1.0.view", @"/Views/Career/VertifyEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Career/VertifyEmail.cshtml", typeof(AspNetCore.Views_Career_VertifyEmail))]
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
#line 1 "D:\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\_ViewImports.cshtml"
using PharmaceuticalsCompany;

#line default
#line hidden
#line 2 "D:\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\_ViewImports.cshtml"
using PharmaceuticalsCompany.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a803fe3883ae00272a4251c6186253e24cf4c6d", @"/Views/Career/VertifyEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff95712ad4d1b0c4998e03c0c67fc75d3390c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Career_VertifyEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Career\VertifyEmail.cshtml"
  
    ViewData["Title"] = "VertifyEmail";

#line default
#line hidden
            BeginContext(50, 27, true);
            WriteLiteral("\r\n<h2>VertifyEmail</h2>\r\n\r\n");
            EndContext();
#line 13 "D:\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Career\VertifyEmail.cshtml"
 if(ViewBag.Msg!=null)
{

#line default
#line hidden
            BeginContext(234, 22, true);
            WriteLiteral("<h1 style=\"color:red\">");
            EndContext();
            BeginContext(257, 11, false);
#line 15 "D:\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Career\VertifyEmail.cshtml"
                 Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(268, 8, true);
            WriteLiteral("</h1> \r\n");
            EndContext();
#line 16 "D:\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Career\VertifyEmail.cshtml"
}
else

{

#line default
#line hidden
            BeginContext(290, 113, true);
            WriteLiteral("<h2>\r\n    thank you for vertifying your email ,you can\r\n    <a href=\"/Career\">click here</a> to continue\r\n</h2>\r\n");
            EndContext();
#line 24 "D:\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Career\VertifyEmail.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
