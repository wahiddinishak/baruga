#pragma checksum "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff916427418a2e828b3555587ae7ef71c8071bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_aduan_Index), @"mvc.1.0.view", @"/Views/aduan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/aduan/Index.cshtml", typeof(AspNetCore.Views_aduan_Index))]
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
#line 8 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#line 9 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 10 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff916427418a2e828b3555587ae7ef71c8071bc", @"/Views/aduan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc88290ff43b5903fc92290fe57eea9ceec2dd", @"/Views/_ViewImports.cshtml")]
    public class Views_aduan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<msUsersPelapor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
  
    ViewData["Title"] = "Aduan";
    Layout = "_PageLayout";

#line default
#line hidden
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(180, 367, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">

        <!-- kolom utama -->
        <div class=""col-8"">

            <!-- submit aduan -->
            <div class=""section"">
                <div class=""container"">
                    <div class=""single-aduan-container"">
                        <div class=""card card-aduan"">
                            ");
            EndContext();
            BeginContext(547, 2594, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd8b4363ca8045569d0197d6fbf3e06d", async() => {
                BeginContext(576, 835, true);
                WriteLiteral(@"
                                <br>
                                <div class=""card-body"">
                                    <div class=""input-group no-border"">
                                        <textarea rows=""6"" class=""form-control"" style=""overflow: hidden;""
                                                  placeholder=""Ketik aduan Anda..""></textarea>
                                    </div>

                                    <div class=""input-group no-border"">
                                        <input type=""text"" class=""form-control"" placeholder=""Email.."">
                                    </div>

                                    <div class=""form-group"">
                                        <select class=""form-control form-control-lg"">
                                            ");
                EndContext();
                BeginContext(1411, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f548100785e44313a690c16616789a55", async() => {
                    BeginContext(1475, 14, true);
                    WriteLiteral("Pilih Kategori");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1498, 1636, true);
                WriteLiteral(@"
                                        </select>
                                    </div>

                                    <!-- upload gambar -->
                                    <div id=""uploadGambar"" style=""background-color: #EEEEEE; display:none;"">
                                        <input id=""demo"" type=""file"" name=""files"" accept="".jpg, .png, image/jpeg, image/png"" multiple>
                                    </div>

                                </div>
                                <div class=""card-footer"">
                                    <div class=""container"">
                                        <div class=""d-flex justify-content-between mb-3"">
                                            <div class=""p-2"">
                                                <button class=""btn btn-primary btn-round"" type=""button"" onclick=""gambarToggle()"">
                                                    <i class=""fas fa-paperclip""></i> Lampiran
                                 ");
                WriteLiteral(@"               </button>
                                            </div>
                                            <div class=""p-2"">
                                                <button class=""btn btn-primary btn-round"" type=""button"">
                                                    <i class=""fas fa-paper-plane""></i> Kirim
                                                </button>
                                            </div>
                                        </div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3141, 300, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>


            <!-- list aduan -->
            <div class=""section"">
                <div class=""container"" style=""margin-top: -100px"">
                    <div class=""d-flex flex-column"">
");
            EndContext();
#line 75 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                         foreach (var aduan in (IEnumerable<listAduan>)ViewBag.AllComplaint)
                        {

#line default
#line hidden
            BeginContext(3562, 204, true);
            WriteLiteral("                            <div class=\"p-2\">\r\n                                <div class=\"card\">\r\n                                    <div class=\"card-header\">\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3766, "\"", 3816, 1);
#line 80 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
WriteAttributeValue("", 3773, String.Concat("/aduan/detail/", @aduan.ID), 3773, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3817, 24, true);
            WriteLiteral(" style=\"color:white;\">\r\n");
            EndContext();
#line 81 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                              
                                                if (aduan.Topics.Length > 81)
                                                {
                                                    

#line default
#line hidden
            BeginContext(4072, 53, false);
#line 84 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                               Write(String.Concat(@aduan.Topics.Substring(0, 78), " ..."));

#line default
#line hidden
            EndContext();
#line 84 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                                                                                          
                                                }
                                                else
                                                {
                                                    

#line default
#line hidden
            BeginContext(4336, 12, false);
#line 88 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                               Write(aduan.Topics);

#line default
#line hidden
            EndContext();
#line 88 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                                                 
                                                }
                                            

#line default
#line hidden
            BeginContext(4448, 412, true);
            WriteLiteral(@"                                        </a>
                                    </div>
                                    <div class=""card-body"">
                                        <div class=""d-flex"">
                                            <div class=""p-2"">
                                                <span class=""fas fa-calendar-alt"">
                                                    ");
            EndContext();
            BeginContext(4861, 19, false);
#line 97 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                               Write(aduan.allocatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(4880, 176, true);
            WriteLiteral("\r\n                                                </span>\r\n                                            </div>\r\n                                            <div class=\"p-2\">\r\n\r\n");
            EndContext();
#line 102 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                                  
                                                    if (aduan.Hide == "0")
                                                    {

#line default
#line hidden
            BeginContext(5239, 148, true);
            WriteLiteral("                                                        <span class=\"fas fa-user-tag\">\r\n                                                            ");
            EndContext();
            BeginContext(5388, 57, false);
#line 106 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                                       Write(String.Concat(@aduan.NamaDepan, " ", @aduan.NamaBelakang));

#line default
#line hidden
            EndContext();
            BeginContext(5445, 67, true);
            WriteLiteral("\r\n                                                        </span>\r\n");
            EndContext();
#line 108 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(5680, 221, true);
            WriteLiteral("                                                        <span class=\"fas fa-user-tag\">\r\n                                                            Anonim\r\n                                                        </span>\r\n");
            EndContext();
#line 114 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(6007, 104, true);
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n\r\n");
            EndContext();
#line 120 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                          
                                            if (aduan.Desc.Length > 200)
                                            {
                                                

#line default
#line hidden
            BeginContext(6325, 54, false);
#line 123 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                           Write(String.Concat(@aduan.Desc.Substring(0, 295), " [...]"));

#line default
#line hidden
            EndContext();
#line 123 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                                                                                       

                                            }
                                            else
                                            {
                                                

#line default
#line hidden
            BeginContext(6576, 10, false);
#line 128 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                           Write(aduan.Desc);

#line default
#line hidden
            EndContext();
#line 128 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                                           
                                            }
                                        

#line default
#line hidden
            BeginContext(6678, 673, true);
            WriteLiteral(@"                                    </div>
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
            BeginWriteAttribute("href", " href=\"", 7351, "\"", 7380, 2);
            WriteAttributeValue("", 7358, "aduan/detail/", 7358, 13, true);
#line 141 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
WriteAttributeValue("", 7371, aduan.ID, 7371, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7381, 531, true);
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
#line 151 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(7939, 117, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"d-flex justify-content-center\">\r\n                        ");
            EndContext();
            BeginContext(8057, 388, false);
#line 154 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                   Write(Html.PagedListPager((IPagedList)ViewBag.AllComplaint, page =>
                               Url.Action("Index", new { page = page }),
                               new PagedListRenderOptions {
                                   LiElementClasses = new string[] { "page-item" },
                                   PageClasses = new string[] { "page-link" }
                        }));

#line default
#line hidden
            EndContext();
            BeginContext(8445, 2438, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>

        <!-- kolom samping -->
        <div class=""col-4"">
            <div class=""sticky-top"">
                <div class=""section"">
                    <div class=""container"">

                        <div class=""d-flex flex-column"">

                            <div class=""p-2"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <label>Penulusuran Aduan</label>
                                    </div>
                                    <div class=""card-body"">
                                        <div class=""input-group no-border"">
                                            <div class=""input-group-prepend"">
                                                <span class=""input-group-text"">
                                                    <i class=""fas fa-hashtag""></i>
                         ");
            WriteLiteral(@"                       </span>
                                            </div>
                                            <input type=""text"" class=""form-control"" placeholder=""ID Aduan .."" style=""height: auto;"" id=""idTrack"" onkeyup=""typeID()"">
                                        </div>
                                        <div class=""col text-center"">
                                            <button class=""btn btn-primary btn-round"" id=""btnTrack"" onclick=""redirect()"">Lacak</button>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""p-2"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <label>Statistik Aduan</label>
                                    </div>
                                    <div class=""card-body"">

       ");
            WriteLiteral(@"                                 <div class=""d-flex flex-row"">
                                            <div class=""p-2"">
                                                <span class=""badge badge-info"">Baru</span>
                                            </div>
                                            <div class=""p-2 ml-auto"">
                                                ");
            EndContext();
            BeginContext(10884, 16, false);
#line 206 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                           Write(ViewData["baru"]);

#line default
#line hidden
            EndContext();
            BeginContext(10900, 505, true);
            WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""d-flex flex-row"">
                                            <div class=""p-2"">
                                                <span class=""badge badge-danger"">Proses</span>
                                            </div>
                                            <div class=""p-2 ml-auto"">
                                                ");
            EndContext();
            BeginContext(11406, 18, false);
#line 215 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                           Write(ViewData["proses"]);

#line default
#line hidden
            EndContext();
            BeginContext(11424, 507, true);
            WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""d-flex flex-row"">
                                            <div class=""p-2"">
                                                <span class=""badge badge-success"">Selesai</span>
                                            </div>
                                            <div class=""p-2 ml-auto"">
                                                ");
            EndContext();
            BeginContext(11932, 19, false);
#line 224 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                           Write(ViewData["selesai"]);

#line default
#line hidden
            EndContext();
            BeginContext(11951, 511, true);
            WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""d-flex flex-row"">
                                            <div class=""p-2"">
                                                <span class=""badge badge-default"">Total Aduan</span>
                                            </div>
                                            <div class=""p-2 ml-auto"">
                                                ");
            EndContext();
            BeginContext(12463, 17, false);
#line 233 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                                           Write(ViewData["total"]);

#line default
#line hidden
            EndContext();
            BeginContext(12480, 366, true);
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(12864, 258, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('#idTrack').value = """";
            $('#btnTrack').prop('disabled', true);

            LoadFrmRegis();
        })

        function LoadFrmRegis()
        {
            $.get('");
                EndContext();
                BeginContext(13123, 30, false);
#line 260 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
              Write(Url.Action("register", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(13153, 390, true);
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
                BeginContext(13544, 30, false);
#line 273 "C:\PROJECT\03 Sulselprov\Baruga\barugaWeb\barugaWeb\Views\aduan\Index.cshtml"
                   Write(Url.Action("register", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(13574, 1297, true);
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

        function typeID() {
            var x = document.getElementById(""idTrack"");
            if (x == """") {
                $('#btnTrack').prop('disabled', true);
            } else {
                $('#btnTrack').prop('disabled', false);
            }
        }

    ");
                WriteLiteral(@"    function redirect() {
            var id = document.getElementById(""idTrack"").value;
            if (id.charAt(0) === ""#"") {
                id = id.substring(1);
            }
            window.location.href = '/aduan/detail/' + id;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<msUsersPelapor> Html { get; private set; }
    }
}
#pragma warning restore 1591
