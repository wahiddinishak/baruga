#pragma checksum "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61823d1ca5b140d12c3e20efdfefc22b30293e1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aspirasi_detail), @"mvc.1.0.view", @"/Views/Aspirasi/detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aspirasi/detail.cshtml", typeof(AspNetCore.Views_Aspirasi_detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61823d1ca5b140d12c3e20efdfefc22b30293e1d", @"/Views/Aspirasi/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc88290ff43b5903fc92290fe57eea9ceec2dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Aspirasi_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<trComplaintLv1>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
     foreach (var aduan in (IEnumerable<listAduan>)ViewBag.oneCase)
    {
        ViewData["Title"] = aduan.Topics;
    }

#line default
#line hidden
#line 7 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
     
    Layout = "~/Views/Shared/_DetailLayout.cshtml";

#line default
#line hidden
            BeginContext(211, 53, true);
            WriteLiteral("\r\n\r\n<div class=\"section\">\r\n    <div class=\"card\">\r\n\r\n");
            EndContext();
#line 15 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
         foreach (var aduan in (IEnumerable<listAduan>)ViewBag.oneCase)
        {

#line default
#line hidden
            BeginContext(348, 177, true);
            WriteLiteral("            <div class=\"card-header\" style=\"background-color: white; color: black;\">\r\n                <label class=\"h5\">\r\n                    <b>\r\n                        ID : #");
            EndContext();
            BeginContext(526, 8, false);
#line 20 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                         Write(aduan.ID);

#line default
#line hidden
            EndContext();
            BeginContext(534, 204, true);
            WriteLiteral("\r\n                    </b>\r\n                </label>\r\n                <div class=\"d-flex\" justify-content-end style=\"background-color: lightgray;\">\r\n                    <div class=\"p-2 mr-auto\"><label><b>");
            EndContext();
            BeginContext(739, 12, false);
#line 24 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                                                  Write(aduan.Topics);

#line default
#line hidden
            EndContext();
            BeginContext(751, 188, true);
            WriteLiteral("</b></label></div>\r\n                    <div class=\"p-2\">\r\n                        <span class=\"fas fa-calendar-alt\">\r\n                            <label>\r\n                                ");
            EndContext();
            BeginContext(940, 38, false);
#line 28 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                           Write(String.Concat(" ", @aduan.createdDate));

#line default
#line hidden
            EndContext();
            BeginContext(978, 140, true);
            WriteLiteral("\r\n                            </label>\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"p-2\">\r\n");
            EndContext();
#line 33 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                          
                            if (@aduan.Status == "2")
                            {

#line default
#line hidden
            BeginContext(1232, 154, true);
            WriteLiteral("                                <span class=\"badge badge-success\">\r\n                                    Selesai\r\n                                </span>\r\n");
            EndContext();
#line 39 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                            }
                            else if (@aduan.Status == "1")
                            {

#line default
#line hidden
            BeginContext(1508, 152, true);
            WriteLiteral("                                <span class=\"badge badge-danger\">\r\n                                    Proses\r\n                                </span>\r\n");
            EndContext();
#line 45 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1756, 148, true);
            WriteLiteral("                                <span class=\"badge badge-info\">\r\n                                    Baru\r\n                                </span>\r\n");
            EndContext();
#line 51 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1962, 220, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-body\" style=\"margin-top: -20px;\">\r\n                <div class=\"p-2\">\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(2183, 10, false);
#line 59 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                   Write(aduan.Desc);

#line default
#line hidden
            EndContext();
            BeginContext(2193, 90, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"d-flex\">\r\n");
            EndContext();
#line 63 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                     foreach (var idPicture in ViewBag.imgSebelum)
                    {

#line default
#line hidden
            BeginContext(2374, 82, true);
            WriteLiteral("                        <a href=\"#\" class=\"pop\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2456, "\"", 2539, 2);
            WriteAttributeValue("", 2462, "http://dev.baruga.sulselprov.go.id/admin/assets/image_lapor/", 2462, 60, true);
#line 66 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
WriteAttributeValue("", 2522, idPicture.imgSrc, 2522, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2540, 79, true);
            WriteLiteral("\r\n                                 class=\"shadow rounded-lg float-sm-left ml-2\"");
            EndContext();
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 2619, "\"", 2677, 1);
#line 68 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
WriteAttributeValue("", 2659, idPicture.caption, 2659, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2678, 101, true);
            WriteLiteral("\r\n                                 style=\"width:70px; height:70px\" />\r\n                        </a>\r\n");
            EndContext();
#line 71 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(2802, 46, true);
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n");
            EndContext();
#line 75 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"

        }

#line default
#line hidden
            BeginContext(2861, 210, true);
            WriteLiteral("\r\n        <div class=\"card-footer\">\r\n            <label class=\"h6 p-2\">\r\n                <b>\r\n                    Tindak Lanjut :\r\n                </b>\r\n            </label>\r\n            <ul class=\"timeline\">\r\n");
            EndContext();
#line 85 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                 foreach (var aduan in (IEnumerable<listAduan>)ViewBag.oneCase)
                {

                    if (aduan.Hide == "0")
                    {


#line default
#line hidden
            BeginContext(3242, 158, true);
            WriteLiteral("                        <li>\r\n                            <label class=\"h6\">Dibuat</label>\r\n                            <label class=\"float-right text-muted\">");
            EndContext();
            BeginContext(3401, 17, false);
#line 93 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                                                             Write(aduan.createdDate);

#line default
#line hidden
            EndContext();
            BeginContext(3418, 161, true);
            WriteLiteral("</label>\r\n                            <p>\r\n                                Dibuat oleh\r\n                                <b>\r\n                                    ");
            EndContext();
            BeginContext(3580, 57, false);
#line 97 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                               Write(String.Concat(@aduan.NamaDepan, " ", @aduan.NamaBelakang));

#line default
#line hidden
            EndContext();
            BeginContext(3637, 105, true);
            WriteLiteral("\r\n                                </b>\r\n                            </p>\r\n                        </li>\r\n");
            EndContext();
#line 101 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3814, 158, true);
            WriteLiteral("                        <li>\r\n                            <label class=\"h6\">Dibuat</label>\r\n                            <label class=\"float-right text-muted\">");
            EndContext();
            BeginContext(3973, 17, false);
#line 106 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                                                             Write(aduan.createdDate);

#line default
#line hidden
            EndContext();
            BeginContext(3990, 272, true);
            WriteLiteral(@"</label>
                            <p>
                                Dibuat oleh
                                <b>
                                    Anonim
                                </b>
                            </p>
                        </li>
");
            EndContext();
#line 114 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                    }

                    if (aduan.allocatedDate != null)
                    {

#line default
#line hidden
            BeginContext(4364, 161, true);
            WriteLiteral("                        <li>\r\n                            <label class=\"h6\">Disposisi</label>\r\n                            <label class=\"float-right text-muted\">");
            EndContext();
            BeginContext(4526, 19, false);
#line 120 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                                                             Write(aduan.allocatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(4545, 93, true);
            WriteLiteral("</label>\r\n                            <p>\r\n                                Didisposisi ke <b>");
            EndContext();
            BeginContext(4639, 15, false);
#line 122 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                                             Write(ViewData["opd"]);

#line default
#line hidden
            EndContext();
            BeginContext(4654, 71, true);
            WriteLiteral("</b>\r\n                            </p>\r\n                        </li>\r\n");
            EndContext();
#line 125 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                        if (aduan.progressDate != null)
                        {

#line default
#line hidden
            BeginContext(4809, 170, true);
            WriteLiteral("                            <li>\r\n                                <label class=\"h6\">Proses</label>\r\n                                <label class=\"float-right text-muted\">");
            EndContext();
            BeginContext(4980, 18, false);
#line 129 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                                                                 Write(aduan.progressDate);

#line default
#line hidden
            EndContext();
            BeginContext(4998, 100, true);
            WriteLiteral("</label>\r\n                                <p>\r\n                                    Diproses oleh <b>");
            EndContext();
            BeginContext(5099, 16, false);
#line 131 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                                                Write(ViewData["opd1"]);

#line default
#line hidden
            EndContext();
            BeginContext(5115, 79, true);
            WriteLiteral("</b>\r\n                                </p>\r\n                            </li>\r\n");
            EndContext();
#line 134 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                            if (aduan.solvedDate != null)
                            {

#line default
#line hidden
            BeginContext(5284, 183, true);
            WriteLiteral("                                <li>\r\n                                    <label class=\"h6\">Selesai</label>\r\n                                    <label class=\"float-right text-muted\">");
            EndContext();
            BeginContext(5468, 16, false);
#line 138 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                                                                     Write(aduan.solvedDate);

#line default
#line hidden
            EndContext();
            BeginContext(5484, 51, true);
            WriteLiteral("</label>\r\n                                    <p>\r\n");
            EndContext();
            BeginContext(5596, 102, true);
            WriteLiteral("                                    </p>\r\n\r\n                                    <div class=\"d-flex\">\r\n");
            EndContext();
#line 144 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                                         foreach (var idPicture in ViewBag.imgSesudah)
                                        {

#line default
#line hidden
            BeginContext(5829, 122, true);
            WriteLiteral("                                            <a href=\"#\" class=\"pop\">\r\n                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5951, "\"", 6034, 2);
            WriteAttributeValue("", 5957, "http://dev.baruga.sulselprov.go.id/admin/assets/image_lapor/", 5957, 60, true);
#line 147 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
WriteAttributeValue("", 6017, idPicture.imgSrc, 6017, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6035, 45, true);
            WriteLiteral(" class=\"shadow rounded-lg float-sm-left ml-2\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 6080, "\"", 6104, 1);
#line 147 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
WriteAttributeValue("", 6086, idPicture.caption, 6086, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6105, 87, true);
            WriteLiteral(" style=\"width:70px; height:70px\" />\r\n                                            </a>\r\n");
            EndContext();
#line 149 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                                        }

#line default
#line hidden
            BeginContext(6235, 83, true);
            WriteLiteral("                                    </div>\r\n                                </li>\r\n");
            EndContext();
#line 152 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                            }
                        }
                    }
                }

#line default
#line hidden
            BeginContext(6418, 450, true);
            WriteLiteral(@"            </ul>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""imagemodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-body text-center"">
                <img src="""" id=""imagepreview""><hr />
                <em id=""caption""></em>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6886, 553, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(function () {
                $('.pop').on('click', function () {
                    var x = document.getElementById(""caption"");
                    $('#imagepreview').attr('src', $(this).find('img').attr('src'));
                    x.append($(this).find('img').attr('alt'));
                    $('#imagemodal').modal('show');
                });
            });

            LoadFrmRegis();
        })

        function LoadFrmRegis()
        {
            $.get('");
                EndContext();
                BeginContext(7440, 30, false);
#line 190 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
              Write(Url.Action("register", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(7470, 390, true);
                WriteLiteral(@"', null, function (result) {
                $('#dvregis').html(result);
                $.validator.unobtrusive.parse('#form-regis');

                $('#btnSimpan').click(function () {
                    ProsesRegis();
                })
            })
        }

        function ProsesRegis()
        {
            if ($('#form-regis').valid()) {
                $.post('");
                EndContext();
                BeginContext(7861, 30, false);
#line 203 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\Aspirasi\detail.cshtml"
                   Write(Url.Action("register", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(7891, 758, true);
                WriteLiteral(@"', $('#form-regis').serializeArray(), function (result) {
                    if (result == '00') {
                        $('#loginModal').modal('hide');

                        Swal.fire(
                            'Register Berhasil !',
                            'Silahkan masuk untuk memulai.',
                            'success'
                        )

                    }
                    else {
                        Swal.fire(
                            'Register Gagal !',
                            'Email sudah pernah digunakan atau silahkan menghubungi admin',
                            'error'
                        )
                    }
                })
            }
        }

    </script>
");
                EndContext();
            }
            );
            BeginContext(8652, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<trComplaintLv1> Html { get; private set; }
    }
}
#pragma warning restore 1591