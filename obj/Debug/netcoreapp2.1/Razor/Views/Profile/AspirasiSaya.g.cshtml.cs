#pragma checksum "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0112b8837583220d452caa8e9fd790b8d1c663a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_AspirasiSaya), @"mvc.1.0.view", @"/Views/Profile/AspirasiSaya.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/AspirasiSaya.cshtml", typeof(AspNetCore.Views_Profile_AspirasiSaya))]
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
#line 1 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\_ViewImports.cshtml"
using barugaWeb;

#line default
#line hidden
#line 2 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\_ViewImports.cshtml"
using barugaWeb.Models;

#line default
#line hidden
#line 7 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
using X.PagedList;

#line default
#line hidden
#line 8 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 9 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0112b8837583220d452caa8e9fd790b8d1c663a5", @"/Views/Profile/AspirasiSaya.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc88290ff43b5903fc92290fe57eea9ceec2dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_AspirasiSaya : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/notlisted.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
  
    ViewData["Title"] = "Aspirasi Saya";
    Layout = "~/Views/Shared/_DetailLayout.cshtml";

#line default
#line hidden
            BeginContext(104, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(189, 1060, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""col-8"">
            <!-- list aduan -->
            <div class=""section"">
                <div class=""container"">
                    <div class=""d-flex"" style=""margin-top: -20px;"">
                        <div class=""p-2"">
                            <h6>Aspirasi Saya</h6>
                        </div>
                        <div class=""p-2 ml-auto"" style=""margin-top: -15px;"">
                            <div class=""input-group no-border"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text"">
                                        <i class=""fas fa-search""></i>
                                    </span>
                                </div>
                                <input type=""text"" class=""form-control"" placeholder=""Cari .."" style=""height: auto;"">
                            </div>
                        </di");
            WriteLiteral("v>\r\n                    </div>\r\n\r\n\r\n");
            EndContext();
#line 34 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                      
                        if (Enumerable.Count(ViewBag.AllComplaint) > 0)
                        {

#line default
#line hidden
            BeginContext(1373, 85, true);
            WriteLiteral("                            <div class=\"d-flex flex-column justify-content-center\">\r\n");
            EndContext();
#line 38 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                 foreach (var aduan in (IEnumerable<listAduan>)ViewBag.AllComplaint)
                                {

#line default
#line hidden
            BeginContext(1595, 236, true);
            WriteLiteral("                                    <div class=\"p-2\">\r\n                                        <div class=\"card\">\r\n                                            <div class=\"card-header\">\r\n                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1831, "\"", 1884, 1);
#line 43 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
WriteAttributeValue("", 1838, String.Concat("/aspirasi/detail/", @aduan.ID), 1838, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1885, 24, true);
            WriteLiteral(" style=\"color:white;\">\r\n");
            EndContext();
#line 44 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                      
                                                        if (@aduan.Topics.Length > 81)
                                                        {
                                                            

#line default
#line hidden
            BeginContext(2173, 53, false);
#line 47 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                       Write(String.Concat(@aduan.Topics.Substring(0, 78), " ..."));

#line default
#line hidden
            EndContext();
#line 47 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                                                                                  
                                                        }
                                                        else
                                                        {
                                                            

#line default
#line hidden
            BeginContext(2469, 12, false);
#line 51 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                       Write(aduan.Topics);

#line default
#line hidden
            EndContext();
#line 51 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                                         
                                                        }
                                                    

#line default
#line hidden
            BeginContext(2597, 468, true);
            WriteLiteral(@"                                                </a>
                                            </div>
                                            <div class=""card-body"">
                                                <div class=""d-flex"">
                                                    <div class=""p-2"">
                                                        <span class=""fas fa-calendar-alt"">
                                                            ");
            EndContext();
            BeginContext(3066, 19, false);
#line 60 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                       Write(aduan.allocatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(3085, 200, true);
            WriteLiteral("\r\n                                                        </span>\r\n                                                    </div>\r\n                                                    <div class=\"p-2\">\r\n\r\n");
            EndContext();
#line 65 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                          
                                                            if (aduan.Hide == "0")
                                                            {

#line default
#line hidden
            BeginContext(3492, 164, true);
            WriteLiteral("                                                                <span class=\"fas fa-user-tag\">\r\n                                                                    ");
            EndContext();
            BeginContext(3657, 57, false);
#line 69 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                               Write(String.Concat(@aduan.NamaDepan, " ", @aduan.NamaBelakang));

#line default
#line hidden
            EndContext();
            BeginContext(3714, 75, true);
            WriteLiteral("\r\n                                                                </span>\r\n");
            EndContext();
#line 71 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
            BeginContext(3981, 245, true);
            WriteLiteral("                                                                <span class=\"fas fa-user-tag\">\r\n                                                                    Anonim\r\n                                                                </span>\r\n");
            EndContext();
#line 77 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                            }
                                                        

#line default
#line hidden
            BeginContext(4348, 244, true);
            WriteLiteral("\r\n                                                    </div>\r\n                                                </div>\r\n\r\n                                                <div class=\"p-2\">\r\n                                                    <p>\r\n");
            EndContext();
#line 85 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                          
                                                            if (aduan.Desc.Length > 200)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(4870, 54, false);
#line 88 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                           Write(String.Concat(@aduan.Desc.Substring(0, 295), " [...]"));

#line default
#line hidden
            EndContext();
#line 88 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                                                                                       

                                                            }
                                                            else
                                                            {
                                                                

#line default
#line hidden
            BeginContext(5185, 10, false);
#line 93 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                           Write(aduan.Desc);

#line default
#line hidden
            EndContext();
#line 93 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                                                           
                                                            }
                                                        

#line default
#line hidden
            BeginContext(5319, 926, true);
            WriteLiteral(@"                                                    </p>
                                                </div>

                                               
                                            </div>
                                            <div class=""card-footer"">
                                                <div class=""d-flex mb-3"">
                                                    <div class=""p-2"">
                                                        <a href=""#!"">
                                                            <i class=""fas fa-heart""></i> 0
                                                            Dukungan
                                                        </a>
                                                    </div>
                                                    <div class=""p-2 ml-auto"">
                                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6245, "\"", 6298, 1);
#line 110 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
WriteAttributeValue("", 6252, String.Concat("/aspirasi/detail/", @aduan.ID), 6252, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6299, 603, true);
            WriteLiteral(@">
                                                            <span class=""badge"" style=""background-image:url(/img/readmore.png);"">
                                                                Selengkapnya
                                                            </span>
                                                        </a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
");
            EndContext();
#line 120 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                                }

#line default
#line hidden
            BeginContext(6937, 143, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"d-flex justify-content-center\">\r\n                                ");
            EndContext();
            BeginContext(7081, 435, false);
#line 124 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                           Write(Html.PagedListPager((IPagedList)ViewBag.AllComplaint, page =>
                                       Url.Action("AspirasiSaya", new { page = page }),
                                       new PagedListRenderOptions {
                                           LiElementClasses = new string[] { "page-item" },
                                           PageClasses = new string[] { "page-link" }
                                }));

#line default
#line hidden
            EndContext();
            BeginContext(7516, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 131 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(7638, 497, true);
            WriteLiteral(@"                            <div class=""d-flex flex-column justify-content-center"">
                                <div class=""text-center"" style=""margin-top: 10px;"">
                                    <h5>
                                        Oh yaa, sepertinya Saya belum pernah menyampaikan aspirasi.
                                    </h5>
                                </div>
                                <div style=""margin-top: 10px;"">
                                    ");
            EndContext();
            BeginContext(8135, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01342ec1bba24164837e624c948533e3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8168, 78, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 144 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Profile\AspirasiSaya.cshtml"

                        }
                    

#line default
#line hidden
            BeginContext(8298, 88, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
