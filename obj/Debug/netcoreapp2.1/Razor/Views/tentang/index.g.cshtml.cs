#pragma checksum "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\tentang\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdbdfae64a28fd288c9d85180088667df4c23c9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_tentang_index), @"mvc.1.0.view", @"/Views/tentang/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/tentang/index.cshtml", typeof(AspNetCore.Views_tentang_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdbdfae64a28fd288c9d85180088667df4c23c9b", @"/Views/tentang/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc88290ff43b5903fc92290fe57eea9ceec2dd", @"/Views/_ViewImports.cshtml")]
    public class Views_tentang_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\tentang\index.cshtml"
  
    ViewData["Title"] = "Tentang";
    Layout = "_PageLayout";

#line default
#line hidden
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Judul", async() => {
                BeginContext(92, 150, true);
                WriteLiteral("\r\n\r\n    <div class=\"container\" style=\"margin-top: 40px;\">\r\n        <h1 class=\"display-6\">\r\n            Apa itu Baruga ?\r\n        </h1>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(245, 2938, true);
            WriteLiteral(@"
<!-- video motion -->
<div class=""section"">
    <div class=""videomotion-container"">
        <iframe width=""800"" height=""415"" src=""https://www.youtube.com/embed/Ps_IiLmeLxQ?controls=0"" frameborder=""0""
                allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
    </div>
</div>

<!-- konten -->
<div class=""section"">
    <div class=""container text-left"" style=""margin-top: -100px;"">
        <p>
            Baruga Pelayanan Masyarakat Provinsi Sulawesi Selatan (BARUGA SULSEL) adalah portal digital pelayanan dan pelaporan masyarakat berbasis web dan aplikasi. Program Baruga merupakan langkah pertama dari Pemerintah Provinsi Sulawesi Selatan untuk mewujudkan pemerintahan yang bersih dan melayani. Dengan meluncurnya Baruga versi 2.0 diharapkan masyarakat lebih mudah untuk mengakses informasi terkait pelayanan dan kegiatan publik beserta melaporkan permasalahan terkait pelayanan publik yang dialaminya. Tidak mungkin Provinsi Sulawesi Selatan ");
            WriteLiteral(@"dapat Berjaya kembali tanpa ikut serta masyarakat publik. Segera diunduh, Baruga versi 2.0 sekarang tersedia di Apple Appstore dan Google Playstore.
        </p>

        <p>
            <h6>
                Definisi BARUGA
            </h6>
            Sebagai bangunan tradisional khas sulawesi selatan yang biasanya menjadi tempat kumpul – kumpul atau diskusi masyarakat, merupakan nama yang paling tepat untuk portal digital pelayanan dan pelaporan yang memfasilitasi aspirasi dan keluhan masyarakat. Besar harapan Pemerintah Provinsi Sulawesi Selatan untuk BARUGA SULSEL agar menjadi tempat berkumpul digital bagi masyarakat untuk berdiskusi terkait informasi dan kegiatan publik sekitar Provinsi Sulawesi Selatan. BARUGA SULSEL juga menyediakan layanan pelaporan untuk masyarakat memberikan masukkan dan keluhan terkait layanan Pemerintah Provinsi Sulawesi Selatan yang mungkin masih kurang dan bisa diperbaiki.
        </p>

        <p>
            <h6>
                Sejarah Aplikasi BARUGA
          ");
            WriteLiteral(@"  </h6>
            Aplikasi BARUGA SULSEL versi 1.0 pertama dibuat dan diluncurkan pada tanggal 18 Oktober 2018 dengan motto “Cepat, Tepat dan Tuntas”. Aplikasi merupakan inovasi dan gebrakan program 100 Hari Gubernur dan Wakil Gubernur Provinsi Sulawesi Selatan Tahun 2018 – 2023. Dalam bulan pertama Aplikasi tersebut diluncurkan, lebih dari 300 laporan masyarakat telah diterima oleh admin dan sampai sekarang terus meningkat. Admin BARUGA SULSEL bertanggung jawab untuk meneruskan dan memastikan status dan selesainya setiap laporan yang masuk ke setiap Organisasi Perangkat Daerah. Seiring berjalannya program ini, banyak masukkan dari masyarakat untuk memperluas cakup BARUGA SULSEL, maka dari itu diluncurkanlah BARUGA SULSEL versi 2.0.
        </p>

        <p class=""text-center"">
            <img src=""./img/lampiran1.jpg"" alt=""alur"">
        </p>

    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3201, 165, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            LoadFrmRegis();\r\n        })\r\n\r\n        function LoadFrmRegis()\r\n        {\r\n            $.get(\'");
                EndContext();
                BeginContext(3367, 30, false);
#line 62 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\tentang\index.cshtml"
              Write(Url.Action("register", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(3397, 390, true);
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
                BeginContext(3788, 30, false);
#line 75 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\tentang\index.cshtml"
                   Write(Url.Action("register", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(3818, 760, true);
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
