#pragma checksum "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842dcf6e516f02c88069300ec7d883c69fdce3f8"
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
#line 1 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\_ViewImports.cshtml"
using PharmaceuticalsCompany;

#line default
#line hidden
#line 2 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\_ViewImports.cshtml"
using PharmaceuticalsCompany.Models;

#line default
#line hidden
#line 6 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842dcf6e516f02c88069300ec7d883c69fdce3f8", @"/Views/Admin/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff95712ad4d1b0c4998e03c0c67fc75d3390c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<Microsoft.AspNetCore.Identity.IdentityRole>>
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
#line 8 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(263, 3593, true);
            WriteLiteral(@"
<style>
 
    .pagination {
        display: inline-block;
        padding-left: 0;
        margin: 20px 0;
        border-radius: 4px;
    }

        .pagination > li {
            display: inline;
        }

            .pagination > li > a,
            .pagination > li > span {
                position: relative;
                float: left;
                padding: 6px 12px;
                margin-left: -1px;
                line-height: 1.42857143;
                color: #337ab7;
                text-decoration: none;
                background-color: #fff;
                border: 1px solid #ddd;
            }

                .pagination > li > a:hover,
                .pagination > li > span:hover,
                .pagination > li > a:focus,
                .pagination > li > span:focus {
                    z-index: 2;
                    color: #23527c;
                    background-color: #eeeeee;
                    border-color: #ddd;
                }

     ");
            WriteLiteral(@"       .pagination > li:first-child > a,
            .pagination > li:first-child > span {
                margin-left: 0;
                border-top-left-radius: 4px;
                border-bottom-left-radius: 4px;
            }

            .pagination > li:last-child > a,
            .pagination > li:last-child > span {
                border-top-right-radius: 4px;
                border-bottom-right-radius: 4px;
            }

        .pagination > .active > a,
        .pagination > .active > span,
        .pagination > .active > a:hover,
        .pagination > .active > span:hover,
        .pagination > .active > a:focus,
        .pagination > .active > span:focus {
            z-index: 3;
            color: #fff;
            cursor: default;
            background-color: #337ab7;
            border-color: #337ab7;
        }

        .pagination > .disabled > span,
        .pagination > .disabled > span:hover,
        .pagination > .disabled > span:focus,
        .pagination >");
            WriteLiteral(@" .disabled > a,
        .pagination > .disabled > a:hover,
        .pagination > .disabled > a:focus {
            color: #777777;
            cursor: not-allowed;
            background-color: #fff;
            border-color: #ddd;
        }

    .pagination-lg > li > a,
    .pagination-lg > li > span {
        padding: 10px 16px;
        font-size: 18px;
        line-height: 1.3333333;
    }

    .pagination-lg > li:first-child > a,
    .pagination-lg > li:first-child > span {
        border-top-left-radius: 6px;
        border-bottom-left-radius: 6px;
    }

    .pagination-lg > li:last-child > a,
    .pagination-lg > li:last-child > span {
        border-top-right-radius: 6px;
        border-bottom-right-radius: 6px;
    }

    .pagination-sm > li > a,
    .pagination-sm > li > span {
        padding: 5px 10px;
        font-size: 12px;
        line-height: 1.5;
    }

    .pagination-sm > li:first-child > a,
    .pagination-sm > li:first-child > span {
        border-to");
            WriteLiteral(@"p-left-radius: 3px;
        border-bottom-left-radius: 3px;
    }

    .pagination-sm > li:last-child > a,
    .pagination-sm > li:last-child > span {
        border-top-right-radius: 3px;
        border-bottom-right-radius: 3px;
    }
</style>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<script>

    $(document).ready(function () {

        $("".paging li"").addClass(""hidden"");
    });

</script>
<style>
</style>
<hr />
<div class=""container-fluid"">
");
            EndContext();
#line 138 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
     if (ViewBag.EditRole != null)
    {

#line default
#line hidden
            BeginContext(3899, 203, true);
            WriteLiteral("        <div class=\"alert alert-success alert-dismissible fadeAlert in\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>Success!</strong> ");
            EndContext();
            BeginContext(4103, 16, false);
#line 142 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                                 Write(ViewBag.EditRole);

#line default
#line hidden
            EndContext();
            BeginContext(4119, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 144 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(4146, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 146 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
     if (ViewBag.Error != null)
    {


#line default
#line hidden
            BeginContext(4188, 199, true);
            WriteLiteral("        <div class=\"alert alert-danger alert-dismissible fadeAlert in\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>Fail!</strong> ");
            EndContext();
            BeginContext(4388, 13, false);
#line 151 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                              Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(4401, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 153 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"




    }

#line default
#line hidden
            BeginContext(4434, 556, true);
            WriteLiteral(@"

    <div class=""row editRole "">
        <div class=""col-lg-12"">
            <!-- general form elements -->
            <div class=""card card-primary"">
                <div class=""card-header"">
                    <h3 class=""card-title"">List Role</h3>
                </div>



                <table class=""table table-bordered table-hover"">
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Action</th>
                    </tr>
                    <tbody>
");
            EndContext();
#line 177 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(5071, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5180, 7, false);
#line 181 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5187, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5303, 9, false);
#line 184 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5312, 143, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5455, "\"", 5480, 2);
            WriteAttributeValue("", 5462, "Role/Edit/", 5462, 10, true);
#line 188 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
WriteAttributeValue("", 5472, item.Id, 5472, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5481, 118, true);
            WriteLiteral(">Edit </a>\r\n                                    |\r\n\r\n\r\n                                    <button data-toggle=\"modal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5599, "\"", 5635, 3);
            WriteAttributeValue("", 5609, "deletefunction(\'", 5609, 16, true);
#line 192 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
WriteAttributeValue("", 5625, item.Id, 5625, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 5633, "\')", 5633, 2, true);
            EndWriteAttribute();
            BeginContext(5636, 147, true);
            WriteLiteral(" data-target=\"#myModalDelete\" class=\"btn btn-danger\">Delete </button>\r\n\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 196 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5810, 445, true);
            WriteLiteral(@"                    </tbody>
                    <tfoot>
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Action</th>

                        </tr>
                    </tfoot>

                </table>
                <div>
                    <nav aria-label=""Suppliers navigation example"" style=""float:right"">
                        ");
            EndContext();
            BeginContext(6256, 74, false);
#line 210 "D:\Group3Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Role\Index.cshtml"
                   Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model }));

#line default
#line hidden
            EndContext();
            BeginContext(6330, 1413, true);
            WriteLiteral(@"
                    </nav>
                </div>
            </div>
            <!-- /.card-body -->



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
        $('.editRole p').removeAttr('hidden');
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
     ");
            WriteLiteral(@"       <div class=""modal-header"">

                <h4 class=""modal-title"" style=""margin-right:10px;color:red"">Delete Confirm </h4>
                <i class='fas fa-exclamation' style='font-size:28px;color:red'></i>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">


                ");
            EndContext();
            BeginContext(7743, 646, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffe346ffbcae45f39dafeccc933094b9", async() => {
                BeginContext(7809, 573, true);
                WriteLiteral(@"

                    <div class=""container"">

                        <p style=""text-align:center"">Are you sure you want to delete this role?</p>
                        <input type=""hidden"" name=""Id"" />
                        <div class=""clearfix"">
                            <button type=""button"" style=""width:49%"" class=""btn btn-danger"" data-dismiss=""modal"">Cancel</button>
                            <button type=""submit"" style=""width:49%"" class=""btn btn-primary""> Ok </button>

                        </div>
                    </div>
                ");
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
            BeginContext(8389, 66, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
