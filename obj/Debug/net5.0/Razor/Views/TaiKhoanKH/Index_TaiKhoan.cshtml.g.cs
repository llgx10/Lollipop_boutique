#pragma checksum "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "129e2a65175f1f2635712bf64aa882183a85d09f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaiKhoanKH_Index_TaiKhoan), @"mvc.1.0.view", @"/Views/TaiKhoanKH/Index_TaiKhoan.cshtml")]
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
#nullable restore
#line 1 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\_ViewImports.cshtml"
using doan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129e2a65175f1f2635712bf64aa882183a85d09f", @"/Views/TaiKhoanKH/Index_TaiKhoan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32245f2a035dda76030e7fe1b4cad468586c06eb", @"/Views/_ViewImports.cshtml")]
    public class Views_TaiKhoanKH_Index_TaiKhoan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Login/Signout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dangxuat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/TaiKhoanKH/DoiPass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("myaccount-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
  
    ViewData["Title"] = "Tài khoản của bạn";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
  
    Khachhang kh = ViewBag.Khachhang;
    List<Dondathang> list_donhang = (List<Dondathang>)ViewBag.dondathang;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main class=""main-content"">
    <div class=""account-page-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""account-dashboard-tab"" data-bs-toggle=""tab"" href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard"" aria-selected=""true"">Dashboard</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab"" href=""#account-orders"" role=""tab"" aria-controls=""account-orders"" aria-selected=""false"">Đơn hàng của bạn</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-address-tab"" data-bs-toggle=""tab"" href=""#account-address"" role=""tab"" a");
            WriteLiteral(@"ria-controls=""account-address"" aria-selected=""false"">Tài khoản của bạn</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-details-tab"" data-bs-toggle=""tab"" href=""#account-details"" role=""tab"" aria-controls=""account-details"" aria-selected=""false"">Đổi mật khẩu</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-9"">
                    <div class=""tab-content myaccount-tab-content"" id=""account-page-tab-content"">
                        <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel"" aria-labelledby=""account-dashboard-tab"">
                            <div class=""myaccount-dashboard"">
                                <div>Xin chào <b>");
#nullable restore
#line 35 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                            Write(kh.TenKh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n                                <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129e2a65175f1f2635712bf64aa882183a85d09f8114", async() => {
                WriteLiteral("(Nếu đây không phải bạn? <a href=\"#\" onclick=\"document.getElementById(\'dangxuat\').submit()\">Đăng xuất</a>)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>                                
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-orders-tab"">
                            <div class=""myaccount-orders"">
                                <h4 class=""small-title"">ĐƠN HÀNG CỦA BẠN</h4>
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered table-hover"">
                                        <tbody>
                                            <tr>
                                                <th>MÃ ĐƠN HÀNG</th>
                                                <th>NGÀY ĐẶT</th>
                                                <th>THÀNH TIỀN</th>
                                                <th>TÌNH TRẠNG</th>
                                                <th></th>
                                            </tr>
");
#nullable restore
#line 52 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                             foreach (var item in list_donhang)
                                            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 55 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                           Write(item.MaDdh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                            <td>");
#nullable restore
#line 57 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                           Write(item.NgayDatHang?.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("                                            <td>");
#nullable restore
#line 59 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                           Write(item.ThanhTien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\n");
#nullable restore
#line 60 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                             if (item.TinhTrangDonHang == 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Đang chuẩn bị</td>\n");
#nullable restore
#line 63 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                            }
                                            else if (item.TinhTrangDonHang == 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Đang giao</td>\n");
#nullable restore
#line 67 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                            }

                                            else if (item.TinhTrangDonHang == 2)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Đã giao</td>\n");
#nullable restore
#line 72 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                            <td>\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129e2a65175f1f2635712bf64aa882183a85d09f13889", async() => {
                WriteLiteral("\n                                                    <a href=\"#\" class=\"btn btn-secondary btn-primary-hover\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4812, "\"", 4869, 3);
                WriteAttributeValue("", 4822, "document.getElementById(\'", 4822, 25, true);
#nullable restore
#line 77 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
WriteAttributeValue("", 4847, item.MaDdh, 4847, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4858, "\').submit()", 4858, 11, true);
                EndWriteAttribute();
                WriteLiteral("><span>View</span></a>\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4628, "/DonHangKH/Index_DonHangKh?madh=", 4628, 32, true);
#nullable restore
#line 76 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
AddHtmlAttributeValue("", 4660, item.MaDdh, 4660, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 76 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
AddHtmlAttributeValue("", 4691, item.MaDdh, 4691, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                \n                                            </td>\n                                        </tr>\n");
#nullable restore
#line 82 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-address"" role=""tabpanel"" aria-labelledby=""account-address-tab"">
                            <div class=""myaccount-address"">
                                <p>Họ tên: ");
#nullable restore
#line 90 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                      Write(kh.TenKh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p>Giới tính: ");
#nullable restore
#line 91 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                         Write(kh.GioiTinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p>Số điện thoại: ");
#nullable restore
#line 92 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                             Write(kh.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p>Địa chỉ: ");
#nullable restore
#line 93 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\TaiKhoanKH\Index_TaiKhoan.cshtml"
                                       Write(kh.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>                                
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-details"" role=""tabpanel"" aria-labelledby=""account-details-tab"">
                            <div class=""myaccount-details"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129e2a65175f1f2635712bf64aa882183a85d09f19480", async() => {
                WriteLiteral(@"
                                    <div class=""myaccount-form-inner"">
                                        <div class=""single-input"">
                                            <label>Mật khẩu hiện tại</label>
                                            <input type=""password"" name=""pass"" required>
                                        </div>
                                        <div class=""single-input"">
                                            <label>Mật khẩu mới</label>
                                            <input type=""password"" id=""passwordtk"" name=""passwordtk"" required>
                                        </div>
                                        <div class=""single-input"">
                                            <label>Xác nhận lại mật khẩu</label>
                                            <input type=""password"" id=""confirmpasswordtk"" name=""confirmpasswordtk"" required>
                                        </div>        
                                        <p id=""");
                WriteLiteral(@"message""></p>
                                        <div class=""single-input"">
                                            <button id=""doimk"" class=""btn btn-custom-size lg-size btn-secondary btn-primary-hover rounded-0"" type=""submit"">
                                                <span>ĐỔI MẬT KHẨU</span>
                                            </button>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</main>");
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
