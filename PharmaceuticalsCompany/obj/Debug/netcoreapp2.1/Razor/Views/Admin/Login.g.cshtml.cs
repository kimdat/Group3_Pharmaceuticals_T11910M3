#pragma checksum "C:\Fptaptech\DoanB\BanHoanChinh0202\PharmaceuticalsCompany\Views\Admin\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "414f1e86921d36c2214c98424b4bafebaea9ac0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Login), @"mvc.1.0.view", @"/Views/Admin/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Login.cshtml", typeof(AspNetCore.Views_Admin_Login))]
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
#line 1 "C:\Fptaptech\DoanB\BanHoanChinh0202\PharmaceuticalsCompany\Views\_ViewImports.cshtml"
using PharmaceuticalsCompany;

#line default
#line hidden
#line 2 "C:\Fptaptech\DoanB\BanHoanChinh0202\PharmaceuticalsCompany\Views\_ViewImports.cshtml"
using PharmaceuticalsCompany.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"414f1e86921d36c2214c98424b4bafebaea9ac0f", @"/Views/Admin/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff95712ad4d1b0c4998e03c0c67fc75d3390c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/KimDat/MainAdminLogin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css//KimDat/util.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Kimdat/LoginAdmin - Copy.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Fptaptech\DoanB\BanHoanChinh0202\PharmaceuticalsCompany\Views\Admin\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(43, 1824, true);
            WriteLiteral(@"




<!--===============================================================================================-->
<link rel=""icon"" type=""image/png"" href=""images/icons/favicon.ico"" />
<!--===============================================================================================-->
<link rel=""stylesheet"" type=""text/css"" href=""vendor/bootstrap/css/bootstrap.min.css"">
<!--===============================================================================================-->
<link rel=""stylesheet"" type=""text/css"" href=""fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
<!--===============================================================================================-->
<link rel=""stylesheet"" type=""text/css"" href=""fonts/Linearicons-Free-v1.0.0/icon-font.min.css"">
<!--===============================================================================================-->
<link rel=""stylesheet"" type=""text/css"" href=""vendor/animate/animate.css"">
<!--================================================================");
            WriteLiteral(@"===============================-->
<link rel=""stylesheet"" type=""text/css"" href=""vendor/css-hamburgers/hamburgers.min.css"">
<!--===============================================================================================-->
<link rel=""stylesheet"" type=""text/css"" href=""vendor/animsition/css/animsition.min.css"">
<!--===============================================================================================-->
<link rel=""stylesheet"" type=""text/css"" href=""vendor/select2/select2.min.css"">
<!--===============================================================================================-->
<link rel=""stylesheet"" type=""text/css"" href=""vendor/daterangepicker/daterangepicker.css"">
<!--===============================================================================================-->
");
            EndContext();
            BeginContext(1867, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ad0c67ea42e45c197c263c6463ea227", async() => {
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
            BeginContext(1945, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1947, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "997dc96abb0243cdb9b085e2f484d2b3", async() => {
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
            BeginContext(2016, 391, true);
            WriteLiteral(@"
<!--===============================================================================================-->
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<div style=""background-color: #666666;"">

    <div class=""limiter"">
        <div class=""container-login100"">
            <div class=""wrap-login100"">
                ");
            EndContext();
            BeginContext(2407, 1176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a06ebb1def43e49a6e4ad73897d233", async() => {
                BeginContext(2490, 1086, true);
                WriteLiteral(@"
                    <span class=""login100-form-title p-b-43"">
                        Login to continue
                    </span>


                    <div class=""wrap-input100 validate-input"" data-validate=""Valid email is required: ex@abc.xyz"">
                        <input class=""input100"" type=""email"" name=""Email"">
                        <span class=""focus-input100""></span>
                        <span class=""label-input100"">Email</span>
                    </div>


                    <div class=""wrap-input100 validate-input"" data-validate=""Password is required"">
                        <input class=""input100"" type=""password"" name=""PassWord"">
                        <span class=""focus-input100""></span>
                        <span class=""label-input100"">Password</span>
                    </div>




                    <div class=""container-login100-form-btn"">
                        <button class=""login100-form-btn"">
                            Login
                     ");
                WriteLiteral("   </button>\r\n                    </div>\r\n\r\n\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3583, 46, true);
            WriteLiteral("\r\n\r\n                <div class=\"login100-more\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3629, "\"", 3690, 3);
            WriteAttributeValue("", 3637, "background:url(\'", 3637, 16, true);
#line 69 "C:\Fptaptech\DoanB\BanHoanChinh0202\PharmaceuticalsCompany\Views\Admin\Login.cshtml"
WriteAttributeValue("", 3653, Url.Content("~/images/bg-01.jpg"), 3653, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 3687, "\');", 3687, 3, true);
            EndWriteAttribute();
            BeginContext(3691, 1465, true);
            WriteLiteral(@" ;"">
                </div>
            </div>
        </div>
    </div>





    <!--===============================================================================================-->
    <script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
    <!--===============================================================================================-->
    <script src=""vendor/animsition/js/animsition.min.js""></script>
    <!--===============================================================================================-->
    <script src=""vendor/bootstrap/js/popper.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.min.js""></script>
    <!--===============================================================================================-->
    <script src=""vendor/select2/select2.min.js""></script>
    <!--===============================================================================================-->
    <script src=""vendor/daterangepicker/moment.min.js""></script>
    <script src");
            WriteLiteral(@"=""vendor/daterangepicker/daterangepicker.js""></script>
    <!--===============================================================================================-->
    <script src=""vendor/countdowntime/countdowntime.js""></script>
    <!--===============================================================================================-->


</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
");
            EndContext();
            BeginContext(5156, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0579fdb2232041f69e02396df985fdad", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5212, 1112, true);
            WriteLiteral(@"
<button type=""button"" class=""btn btn-primary modalValid"" data-toggle=""modal"" data-target=""#ModalValid"" hidden>
    Launch demo modal
</button>
<div class=""modal fade"" id=""ModalValid"" data-backdrop=""static"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">

            <div class=""modal-body"">
                <p></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>

    </div>
</div>
<div class=""wait""></div>
<style>
    .wait {
        display: none;
        position: fixed;
        z-index: 1000;
        top: 0;
        left: 0;
        height: 100%;
        width: 100%;
        background: rgba( 255, 255, 255, .8 ) url('http://i.stack.imgur.com/FhHRx.gif') 50% 50% no-repeat;
    }


    body.loading .wait {
        overflow");
            WriteLiteral(": hidden;\r\n    }\r\n\r\n\r\n    body.loading .wait {\r\n        display: block;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
