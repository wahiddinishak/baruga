#pragma checksum "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\_detailnotfound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4e1e4a3c468e3961b6909b15ab16c006c609de8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aspirasi__detailnotfound), @"mvc.1.0.view", @"/Views/Aspirasi/_detailnotfound.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aspirasi/_detailnotfound.cshtml", typeof(AspNetCore.Views_Aspirasi__detailnotfound))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e1e4a3c468e3961b6909b15ab16c006c609de8", @"/Views/Aspirasi/_detailnotfound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc88290ff43b5903fc92290fe57eea9ceec2dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Aspirasi__detailnotfound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/notfound.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\_detailnotfound.cshtml"
  
    ViewData["Title"] = "Aduan Tidak Ditemukan";
    Layout = "_DetailLayout";

#line default
#line hidden
            BeginContext(90, 121, true);
            WriteLiteral("\r\n<!-- konten aduan -->\r\n<div class=\"section\">\r\n    <label class=\"h5\">\r\n        <b>\r\n            Hasil Penelusuran ID : #");
            EndContext();
            BeginContext(212, 14, false);
#line 11 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\_detailnotfound.cshtml"
                               Write(ViewData["id"]);

#line default
#line hidden
            EndContext();
            BeginContext(226, 413, true);
            WriteLiteral(@"
        </b>
    </label>
    <div class=""d-flex"" style=""margin-bottom: -70px;"">
        <div class=""text-center"" style=""margin-top: 150px;"">
            <h1>Opps!</h1>
            <p>
                Pencarian anda dalam tahap moderasi atau tidak ditemukan,
                silahkan melakukan penelusuran kembali.
            </p>
        </div>
        <div style=""margin-top: -50px;"">
            ");
            EndContext();
            BeginContext(639, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4c77a30831a4f89b02846a713a70c33", async() => {
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
            BeginContext(671, 202, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"text-center\">\r\n        <button class=\"btn btn-primary btn-round\" onclick=\"window.history.back()\">Kembali ke halaman sebelumnya.</button>\r\n    </div>\r\n</div>");
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
