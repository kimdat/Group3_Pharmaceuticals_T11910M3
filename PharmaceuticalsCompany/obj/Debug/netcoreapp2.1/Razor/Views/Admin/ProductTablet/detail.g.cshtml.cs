#pragma checksum "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544ae1d7159355910fbac01c8614e6a45e21782f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductTablet_detail), @"mvc.1.0.view", @"/Views/Admin/ProductTablet/detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ProductTablet/detail.cshtml", typeof(AspNetCore.Views_Admin_ProductTablet_detail))]
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
#line 1 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\_ViewImports.cshtml"
using PharmaceuticalsCompany;

#line default
#line hidden
#line 2 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\_ViewImports.cshtml"
using PharmaceuticalsCompany.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544ae1d7159355910fbac01c8614e6a45e21782f", @"/Views/Admin/ProductTablet/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff95712ad4d1b0c4998e03c0c67fc75d3390c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductTablet_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PharmaceuticalsCompany.Models.Products.ProductTablet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
  
    ViewData["Title"] = "detail";

#line default
#line hidden
            BeginContext(105, 98, true);
            WriteLiteral("\r\n<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(203, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9692dfa64604fa088b4ddb959a4dd10", async() => {
                BeginContext(247, 5, true);
                WriteLiteral("Home/");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(256, 43, true);
            WriteLiteral("</li>\r\n        <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(299, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8936c439b9504ba6adc9aa3d5048ec65", async() => {
                BeginContext(345, 15, true);
                WriteLiteral("Product Capsule");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(364, 210, true);
            WriteLiteral("</li>\r\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">Capsule/ Encapsulation</li>\r\n    </ol>\r\n</nav>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(574, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "04f34bf1ba874586b310850e9f76143e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 584, "~/", 584, 2, true);
#line 17 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
AddHtmlAttributeValue("", 586, Url.Content(Model.TabPhoto), 586, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(648, 89, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-7\" style=\"border-radius:0;\">\r\n\r\n            ");
            EndContext();
            BeginContext(737, 2729, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee8886823e094fc08fd0701c34a759ca", async() => {
                BeginContext(743, 241, true);
                WriteLiteral("\r\n                <div class=\"jumbotron\">\r\n                    <h4 style=\"margin-top:-50px; margin-left:-40px;\">Product Details </h4>\r\n                    <dl class=\"dl-horizontal\">\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(985, 43, false);
#line 26 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.TabName));

#line default
#line hidden
                EndContext();
                BeginContext(1028, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(1120, 39, false);
#line 29 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayFor(model => model.TabName));

#line default
#line hidden
                EndContext();
                BeginContext(1159, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(1251, 48, false);
#line 32 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.Model_Number));

#line default
#line hidden
                EndContext();
                BeginContext(1299, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(1391, 44, false);
#line 35 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayFor(model => model.Model_Number));

#line default
#line hidden
                EndContext();
                BeginContext(1435, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(1527, 40, false);
#line 38 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.Dies));

#line default
#line hidden
                EndContext();
                BeginContext(1567, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(1659, 36, false);
#line 41 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayFor(model => model.Dies));

#line default
#line hidden
                EndContext();
                BeginContext(1695, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(1787, 47, false);
#line 44 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.MaxPressure));

#line default
#line hidden
                EndContext();
                BeginContext(1834, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(1926, 43, false);
#line 47 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayFor(model => model.MaxPressure));

#line default
#line hidden
                EndContext();
                BeginContext(1969, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(2061, 47, false);
#line 50 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.MaxDiameter));

#line default
#line hidden
                EndContext();
                BeginContext(2108, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(2200, 43, false);
#line 53 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayFor(model => model.MaxDiameter));

#line default
#line hidden
                EndContext();
                BeginContext(2243, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(2335, 43, false);
#line 56 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.MaxDept));

#line default
#line hidden
                EndContext();
                BeginContext(2378, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(2470, 39, false);
#line 59 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayFor(model => model.MaxDept));

#line default
#line hidden
                EndContext();
                BeginContext(2509, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(2601, 51, false);
#line 62 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.ProductCapacity));

#line default
#line hidden
                EndContext();
                BeginContext(2652, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(2744, 47, false);
#line 65 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayFor(model => model.ProductCapacity));

#line default
#line hidden
                EndContext();
                BeginContext(2791, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(2883, 47, false);
#line 68 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.MachineSize));

#line default
#line hidden
                EndContext();
                BeginContext(2930, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(3022, 43, false);
#line 71 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayFor(model => model.MachineSize));

#line default
#line hidden
                EndContext();
                BeginContext(3065, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(3157, 45, false);
#line 74 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.NetWeight));

#line default
#line hidden
                EndContext();
                BeginContext(3202, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(3294, 41, false);
#line 77 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\detail.cshtml"
                       Write(Html.DisplayFor(model => model.NetWeight));

#line default
#line hidden
                EndContext();
                BeginContext(3335, 124, true);
                WriteLiteral("\r\n                        </dd>\r\n                      \r\n                    </dl>\r\n\r\n\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3466, 44, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PharmaceuticalsCompany.Models.Products.ProductTablet> Html { get; private set; }
    }
}
#pragma warning restore 1591
