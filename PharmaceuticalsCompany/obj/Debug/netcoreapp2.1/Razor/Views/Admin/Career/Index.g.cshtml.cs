#pragma checksum "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e8aaead7ba05c3207a08aad560242b5eee124f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Career_Index), @"mvc.1.0.view", @"/Views/Admin/Career/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Career/Index.cshtml", typeof(AspNetCore.Views_Admin_Career_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e8aaead7ba05c3207a08aad560242b5eee124f", @"/Views/Admin/Career/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff95712ad4d1b0c4998e03c0c67fc75d3390c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Career_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PharmaceuticalsCompany.Models.Career.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/KimDat/AdminCareer  - Copy.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/KimDat/css-loader.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Kimdat/jquery-3.2.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sendmail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validMail()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminCareer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a97ca5228d249b28c65e2efdc24dadd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(85, 3, true);
            WriteLiteral("\"\r\n");
            EndContext();
            BeginContext(88, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "df787317bde14e548d58238133b54467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";


#line default
#line hidden
#line 9 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
  
    int count = 1;

#line default
#line hidden
            BeginContext(364, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(368, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd0a7eb8593948869c1719ef9754c387", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(423, 2310, true);
            WriteLiteral(@"


<style>
    .loader {
        border: 16px solid #f3f3f3;
        border-radius: 50%;
        border-top: 16px solid #3498db;
        width: 120px;
        height: 120px;
        -webkit-animation: spin 2s linear infinite; /* Safari */
        animation: spin 2s linear infinite;
    }
</style>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script>
    $(document).ready(function () {

        $(""#sendmail"").submit(function (e) {
            var check = true;
            if ($(""input[name = 'Subject']"").val().trim() == '') {
                $("".errorSubject"").html(""subject is required"");
                // thisalert.html(""subject is required"");
                check = false;
            }
            if ($(""textarea[name = 'Message']"").val().trim() == '') {
                $("".errorMessage"").html(""Message is required"");
                check = false;
            }

            e.preventDefault();
            if (check == true) {

   ");
            WriteLiteral(@"             $.ajax({
                    method: 'post',
                    url: this.action,
                    data: $(this).serialize(),
                    datatype: 'json',
                    beforeSend: function () { $('.Waitsendmail').show(); },
                    complete: function () {
                        $('.Waitsendmail').hide();
                        $('.success').show(0).delay(5000).hide(0);
                        sucessClose()

                    },
                    error: function (xhr) {

                    },
                    success: function (result) {
                        if (!result.success) {

                            alert(""error"");



                        }
                        else {

                           // alert(""you have sent email successfully for "" + $(""input[name='To']"").val());
                            //   window.location.href = ""/Career""
                        }

                        // location.reload(");
            WriteLiteral(@");
                        //var a=data.status;
                        //alert(a);
                        //  document.getElementById(""total"").innerHTML = 123;
                    }

                });
            }

        });
    });
</script>
");
            EndContext();
#line 88 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
 if (Model.Any())
{





#line default
#line hidden
            BeginContext(2763, 169, true);
            WriteLiteral("    <div class=\"card\">\r\n\r\n\r\n        <div class=\"card-header\">\r\n            List USER\r\n        </div>\r\n        <!-- /.card-header -->\r\n        <div class=\"card-body\">\r\n\r\n");
            EndContext();
#line 103 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
             foreach (var item in Model)
            {



#line default
#line hidden
            BeginContext(2993, 442, true);
            WriteLiteral(@"                <div class=""container-fluid"" style=""margin-bottom:20px"">
                    <div class=""row"">
                        <div class=""offset-md-3 col-md-6"">
                            <!-- general form elements -->
                            <div class=""card card-primary"">
                                <div class=""card-header d-inline-block"">
                                    <h3 class=""card-title"">Infro personal ");
            EndContext();
            BeginContext(3436, 5, false);
#line 113 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                                                     Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(3441, 144, true);
            WriteLiteral("</h3>\r\n\r\n                                </div>\r\n\r\n                                <div class=\"card-body\">\r\n                                    ");
            EndContext();
            BeginContext(3585, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f59c9d37b1d54f3093036c179d321782", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 118 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3651, 197, true);
            WriteLiteral("\r\n\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-lg-4\">\r\n                                            <label style=\"font-size:28px\">");
            EndContext();
            BeginContext(3849, 13, false);
#line 122 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                                                     Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3862, 114, true);
            WriteLiteral("</label>\r\n\r\n\r\n                                            <br />\r\n                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3976, "\"", 3994, 2);
            WriteAttributeValue("", 3982, "/", 3982, 1, true);
#line 126 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
WriteAttributeValue("", 3983, item.Photo, 3983, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3995, 296, true);
            WriteLiteral(@" style=""width:100%;height:200px"">
                                            <br />

                                        </div>
                                        <div class=""col-lg-8"" style=""font-size:26px;padding-top:45px"">


                                            Phone: ");
            EndContext();
            BeginContext(4292, 16, false);
#line 133 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                              Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4308, 115, true);
            WriteLiteral("\r\n                                            <br />\r\n\r\n                                            Date Of Birth: ");
            EndContext();
            BeginContext(4424, 68, false);
#line 136 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                                      Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", @item.DateOfBirth)));

#line default
#line hidden
            EndContext();
            BeginContext(4492, 54, true);
            WriteLiteral("\r\n                                            <br />\r\n");
            EndContext();
#line 138 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                             if (item.Gender == true)
                                            {

#line default
#line hidden
            BeginContext(4664, 83, true);
            WriteLiteral("                                                <label>Gender:Male</label> <br />\r\n");
            EndContext();
#line 141 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(4891, 89, true);
            WriteLiteral("                                                <label>   Gender: Female</label> <br />\r\n");
            EndContext();
#line 145 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(5027, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 147 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                             if (item.EmailConfirmed)
                                            {

#line default
#line hidden
            BeginContext(5147, 82, true);
            WriteLiteral("                                                <p>  Email: <a data-toggle=\"modal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5229, "\"", 5279, 5);
            WriteAttributeValue("", 5239, "sendmail(\'", 5239, 10, true);
#line 149 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
WriteAttributeValue("", 5249, item.Email, 5249, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 5260, "\',\'", 5260, 3, true);
#line 149 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
WriteAttributeValue("", 5263, item.FullName, 5263, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 5277, "\')", 5277, 2, true);
            EndWriteAttribute();
            BeginContext(5280, 43, true);
            WriteLiteral(" data-target=\"#myModal\" style=\"color:blue\">");
            EndContext();
            BeginContext(5324, 10, false);
#line 149 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                                                                                                                                                           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(5334, 10, true);
            WriteLiteral("</a></p>\r\n");
            EndContext();
#line 150 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"

                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(5490, 142, true);
            WriteLiteral("                                                <p style=\"  white-space: normal;\">\r\n                                                    Email:");
            EndContext();
            BeginContext(5633, 10, false);
#line 155 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                                     Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(5643, 134, true);
            WriteLiteral("\r\n                                                    (has not been vertified)\r\n                                                </p>\r\n");
            EndContext();
#line 158 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(5824, 174, true);
            WriteLiteral("\r\n                                            <br /><br />\r\n                                        </div>\r\n                                        <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5998, "\"", 6028, 2);
            WriteAttributeValue("", 6005, "Career/Profile/", 6005, 15, true);
#line 162 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
WriteAttributeValue("", 6020, item.Id, 6020, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6029, 427, true);
            WriteLiteral(@" style=""position:absolute;bottom:0;margin:auto;right:0"">
                                            watch Details

                                        </a>
                                    </div>
                                </div>
                                <!-- /.card-body -->


                            </div>
                        </div>
                    </div>
                </div>
");
            EndContext();
            BeginContext(6458, 61, true);
            WriteLiteral("                <div class=\"row\">\r\n\r\n                </div>\r\n");
            EndContext();
#line 179 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"
                count = count + 1;

            }

#line default
#line hidden
            BeginContext(6572, 82, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <!-- /.card-body -->\r\n    </div>\r\n    <!-- /.col -->\r\n");
            EndContext();
            BeginContext(6656, 20, true);
            WriteLiteral("    <!-- /.row -->\r\n");
            EndContext();
            BeginContext(6678, 493, true);
            WriteLiteral(@"    <!-- Modal -->
    <div class=""modal fade sendmail"" id=""myModal"" role=""dialog"">


        <div class=""modal-dialog"">

            <!-- Modal content-->
            <div class=""modal-content"">
                <div class=""modal-header"">

                    <h4 class=""modal-title"">New Message</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">
                    ");
            EndContext();
            BeginContext(7171, 1462, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52e4fe966174053847d9b9fb571d5fa", async() => {
                BeginContext(7286, 1340, true);
                WriteLiteral(@"
                        <input type=""hidden"" name=""ReceiveName"" />
                        <div class=""form-group"">
                            <div class=""email"">
                                <label for="""" style=""margin-right:35px"">To:</label>
                                <input readonly name=""To"" class=""form-control"">
                            </div>
                        </div>


                        <div class=""form-group"">
                            <div class=""email"">
                                <label for="""">Subject:</label>
                                <input type=""text"" class=""form-control"" name=""Subject"">
                            </div>
                            <span class=""errorSubject"" style=""color:red""></span>

                        </div>
                        <div class=""form-group"">

                            <label for="""">Message:</label>
                            <textarea class=""form-control"" name=""Message""></textarea>

            ");
                WriteLiteral(@"                <span class=""errorMessage"" style=""color:red""></span>
                        </div>
                        <div class=""form-group"">

                            <button type=""submit"" style=""width:100%"" class=""btn btn-primary""> Send </button>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8633, 248, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <button type=\"button\" class=\"btn btn-danger\" data-dismiss=\"modal\">Close</button>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 244 "C:\Fptaptech\Doan\Group3_Pharmaceuticals_T11910M3\PharmaceuticalsCompany\Views\Admin\Career\Index.cshtml"

}

#line default
#line hidden
            BeginContext(8886, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fecb21c91894435e98ab1d27fdea1cce", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8941, 1295, true);
            WriteLiteral(@"


<script>

    function sendmail(to, name) {
        $(""input[name = 'Subject']"").val("""");
        $(""textarea[name = 'Message']"").val("""");
        $(""input[name='To']"").val(to);
        $(""input[name='ReceiveName']"").val(name);
    }
    $(""input[name = 'Subject']"").focus(function () {
        $("".errorSubject"").html("""");
    });
    $(""textarea[name = 'Message']"").focus(function () {
        $("".errorMessage"").html("""");
    });
    function validMail() {

        return check;
    }
</script>

<div class=""wait Waitsendmail"">
    <div class=""wrapper"">
        <div class=""inner"">
            <span>P</span>
            <span>L</span>
            <span>E</span>
            <span>A</span>
            <span>S</span>
            <span>E</span>
            <span>w</span>
            <span>A</span>
            <span>I</span>
            <span>T</span>

        </div>
    </div>
</div>

<div class=""wait  success"">

    <div class=""loading"">

        <div class=""loading__");
            WriteLiteral(@"letter"">S</div>
        <div class=""loading__letter"">U</div>
        <div class=""loading__letter"">C</div>
        <div class=""loading__letter"">E</div>
        <div class=""loading__letter"">S</div>
        <div class=""loading__letter"">S</div>

    </div>

</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PharmaceuticalsCompany.Models.Career.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
