#pragma checksum "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f50f9c4c73cb1969e699f473ffc794039d56890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductTablet_Index), @"mvc.1.0.view", @"/Views/Admin/ProductTablet/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ProductTablet/Index.cshtml", typeof(AspNetCore.Views_Admin_ProductTablet_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f50f9c4c73cb1969e699f473ffc794039d56890", @"/Views/Admin/ProductTablet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff95712ad4d1b0c4998e03c0c67fc75d3390c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductTablet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PharmaceuticalsCompany.Models.Products.ProductTablet>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tablest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(169, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(198, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "180ad32ee88a4206980c3977e11c067a", async() => {
                BeginContext(246, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(260, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 43, false);
#line 17 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TabName));

#line default
#line hidden
            EndContext();
            BeginContext(396, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(452, 48, false);
#line 20 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Model_Number));

#line default
#line hidden
            EndContext();
            BeginContext(500, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(556, 40, false);
#line 23 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dies));

#line default
#line hidden
            EndContext();
            BeginContext(596, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(652, 47, false);
#line 26 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaxPressure));

#line default
#line hidden
            EndContext();
            BeginContext(699, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(755, 47, false);
#line 29 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaxDiameter));

#line default
#line hidden
            EndContext();
            BeginContext(802, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(858, 43, false);
#line 32 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaxDept));

#line default
#line hidden
            EndContext();
            BeginContext(901, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(957, 51, false);
#line 35 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductCapacity));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1064, 47, false);
#line 38 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MachineSize));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1167, 45, false);
#line 41 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NetWeight));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1268, 44, false);
#line 44 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TabPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 50 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1430, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1479, 42, false);
#line 53 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TabName));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1577, 47, false);
#line 56 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model_Number));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1680, 39, false);
#line 59 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dies));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1775, 46, false);
#line 62 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaxPressure));

#line default
#line hidden
            EndContext();
            BeginContext(1821, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1877, 46, false);
#line 65 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaxDiameter));

#line default
#line hidden
            EndContext();
            BeginContext(1923, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1979, 42, false);
#line 68 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaxDept));

#line default
#line hidden
            EndContext();
            BeginContext(2021, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2077, 50, false);
#line 71 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductCapacity));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2183, 46, false);
#line 74 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MachineSize));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2285, 44, false);
#line 77 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NetWeight));

#line default
#line hidden
            EndContext();
            BeginContext(2329, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2402, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e85f18490a9b4b009c2dbcefc9130c90", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2424, "~/", 2424, 2, true);
#line 81 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
AddHtmlAttributeValue("", 2426, Url.Content(item.TabPhoto), 2426, 27, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2457, 74, true);
            WriteLiteral("\r\n            </td>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2531, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf6ee73a33c4505a2d389b79c387ebb", async() => {
                BeginContext(2581, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
                                         WriteLiteral(item.TabId);

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
            BeginContext(2589, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2609, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0dca850a8bd4de8bcc42a0aec416d11", async() => {
                BeginContext(2659, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
                                         WriteLiteral(item.TabId);

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
            BeginContext(2670, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2690, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8028ebce65a24333bea8c43e823c8058", async() => {
                BeginContext(2740, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
                                         WriteLiteral(item.TabId);

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
            BeginContext(2750, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 90 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductTablet\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2789, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PharmaceuticalsCompany.Models.Products.ProductTablet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
