#pragma checksum "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3e13d8fa7431312c8516d0be1def0df4e5f8b83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductCapsule_delete), @"mvc.1.0.view", @"/Views/Admin/ProductCapsule/delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ProductCapsule/delete.cshtml", typeof(AspNetCore.Views_Admin_ProductCapsule_delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e13d8fa7431312c8516d0be1def0df4e5f8b83", @"/Views/Admin/ProductCapsule/delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff95712ad4d1b0c4998e03c0c67fc75d3390c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductCapsule_delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PharmaceuticalsCompany.Models.Products.ProductCapsule>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
  
    ViewData["Title"] = "delete";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(158, 265, true);
            WriteLiteral(@"
<h2>delete</h2>
<input name=""file"" type=""file"" onclick=""fileClicked(event)"" onchange=""fileChanged(event)"">
<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>ProductCapsule</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            ");
            EndContext();
            BeginContext(424, 43, false);
#line 16 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CapName));

#line default
#line hidden
            EndContext();
            BeginContext(467, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(511, 39, false);
#line 19 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
       Write(Html.DisplayFor(model => model.CapName));

#line default
#line hidden
            EndContext();
            BeginContext(550, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(594, 41, false);
#line 22 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ouput));

#line default
#line hidden
            EndContext();
            BeginContext(635, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(679, 37, false);
#line 25 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
       Write(Html.DisplayFor(model => model.Ouput));

#line default
#line hidden
            EndContext();
            BeginContext(716, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(760, 43, false);
#line 28 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CapSize));

#line default
#line hidden
            EndContext();
            BeginContext(803, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(847, 39, false);
#line 31 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
       Write(Html.DisplayFor(model => model.CapSize));

#line default
#line hidden
            EndContext();
            BeginContext(886, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(930, 53, false);
#line 34 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Machine_Dimension));

#line default
#line hidden
            EndContext();
            BeginContext(983, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1027, 49, false);
#line 37 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
       Write(Html.DisplayFor(model => model.Machine_Dimension));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1120, 44, false);
#line 40 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Shipping));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1208, 40, false);
#line 43 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
       Write(Html.DisplayFor(model => model.Shipping));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 33, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n\r\n");
            EndContext();
            BeginContext(1374, 36, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1410, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27c3050ce4df46adadb1bc998e61e71c", async() => {
                BeginContext(1436, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1446, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33e73c56488948bbb048b50ab1a3553f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 54 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\ProductCapsule\delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CapId);

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
                BeginContext(1485, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1569, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e3d33f7ec74406a78a59caffbbc024", async() => {
                    BeginContext(1591, 12, true);
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
                BeginContext(1607, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1620, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PharmaceuticalsCompany.Models.Products.ProductCapsule> Html { get; private set; }
    }
}
#pragma warning restore 1591
