#pragma checksum "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "702482e1814c490fddcff634b4f1e070037b29d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Role_Index), @"mvc.1.0.view", @"/Views/Admin/Role/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Role/Index.cshtml", typeof(AspNetCore.Views_Admin_Role_Index))]
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
#line 1 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\_ViewImports.cshtml"
using PharmaceuticalsCompany;

#line default
#line hidden
#line 2 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\_ViewImports.cshtml"
using PharmaceuticalsCompany.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"702482e1814c490fddcff634b4f1e070037b29d5", @"/Views/Admin/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff95712ad4d1b0c4998e03c0c67fc75d3390c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
#line 6 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(166, 43, true);
            WriteLiteral("\r\n\r\n<hr />\r\n<div class=\"container-fluid\">\r\n");
            EndContext();
#line 14 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
     if (ViewBag.EditRole != null)
    {

#line default
#line hidden
            BeginContext(252, 76, true);
            WriteLiteral("        <div class=\"p-3 mb-2 bg-info text-white \" style=\"text-align:center\">");
            EndContext();
            BeginContext(329, 16, false);
#line 16 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                                                                       Write(ViewBag.EditRole);

#line default
#line hidden
            EndContext();
            BeginContext(345, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 17 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(360, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 18 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
     if (ViewBag.Error != null)
    {

#line default
#line hidden
            BeginContext(400, 78, true);
            WriteLiteral("        <div class=\"p-3 mb-2 bg-danger text-white \" style=\"text-align:center\">");
            EndContext();
            BeginContext(479, 13, false);
#line 20 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                                                                         Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(492, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 21 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(507, 774, true);
            WriteLiteral(@"    <div class=""row editRole "">
        <div class=""col-lg-12"">
            <!-- general form elements -->
            <div class=""card card-primary"">
                <div class=""card-header"">
                    <h3 class=""card-title"">List Role</h3>
                </div>

                <div class=""card-body"">
                    <div class=""row product"">
                        <div class=""col-md-4"">
                            <h3>  Id</h3>
                        </div>
                        <div class=""col-md-4"">
                            <h3>  Name</h3>
                        </div>
                        <div class=""col-md-2"">
                            <h3>  Action</h3>
                        </div>
                    </div>
");
            EndContext();
#line 42 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1354, 187, true);
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-4\" style=\"display:inline-flex;\">\r\n                                <p class=\"Role\" hidden>Id:</p> ");
            EndContext();
            BeginContext(1542, 7, false);
#line 46 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1549, 185, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-4\" style=\"display:inline-flex;\">\r\n                                <p class=\"Role\" hidden>Name:</p>  ");
            EndContext();
            BeginContext(1735, 9, false);
#line 49 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1744, 195, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-4\" style=\"display:inline-flex;margin-bottom:10px\">\r\n                                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1939, "\"", 1964, 2);
            WriteAttributeValue("", 1946, "Role/Edit/", 1946, 10, true);
#line 52 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
WriteAttributeValue("", 1956, item.Id, 1956, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1965, 79, true);
            WriteLiteral(">Edit </a>\r\n                                |\r\n                                ");
            EndContext();
            BeginContext(2044, 277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "228af117d71e436880816eb9bf500ecb", async() => {
                BeginContext(2110, 47, true);
                WriteLiteral("\r\n\r\n                                    <button");
                EndContext();
                BeginWriteAttribute("onclick", "  onclick=\"", 2157, "\"", 2194, 3);
                WriteAttributeValue("", 2168, "deletefunction(\'", 2168, 16, true);
#line 56 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
WriteAttributeValue("", 2184, item.Id, 2184, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 2192, "\')", 2192, 2, true);
                EndWriteAttribute();
                BeginContext(2195, 119, true);
                WriteLiteral(" data-target=\"#myModalDelete\"  class=\"btn btn-danger\" type=\"submit\" >Delete </button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(2321, 70, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 60 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2414, 1720, true);
            WriteLiteral(@"
                    <div class=""row product"">
                        <div class=""col-md-4"">
                            <h3>  Id</h3>
                        </div>
                        <div class=""col-md-4"">
                            <h3>  Name</h3>
                        </div>
                        <div class=""col-md-4"">
                            <h3>  Action</h3>
                        </div>
                    </div>


                </div>
                <!-- /.card-body -->



            </div>
        </div>
    </div>
</div>

<script src=""https://code.jquery.com/jquery-1.9.1.min.js""></script>
<script>

    function deletefunction(id) {
        $(""input[name = 'Id']"").val("""");
    
        $(""input[name='Id']"").val(id);
     
    }

    const mediaQuery = window.matchMedia('(min-width: 408px)');
    if (mediaQuery.matches) {
        // Then trigger an alert

        $("".product"").attr(""hidden"", true);
        $('.editRole p').removeAttr('hidden')");
            WriteLiteral(@";
    }
    if (window.matchMedia('(min-width: 768px)').matches) {

        $("".product"").removeAttr(""hidden"");
        $('.editRole p').attr('hidden', true);
        // do functionality on screens smaller than 768px
    }

</script>
<!-- Modal -->
<div class=""modal fade sendmail"" id=""myModalDelete"" role=""dialog"">


    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">

                <h4 class=""modal-title"">e Delete</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(4134, 289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "364d1cf6e3cb4a2fad888d5194d83249", async() => {
                BeginContext(4200, 216, true);
                WriteLiteral("\r\n                    <input type=\"text\" name=\"Id\" />\r\n                  \r\n                        <button type=\"submit\" style=\"width:100%\" class=\"btn btn-primary\"> Ok </button>\r\n                   \r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(4423, 218, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-danger\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
