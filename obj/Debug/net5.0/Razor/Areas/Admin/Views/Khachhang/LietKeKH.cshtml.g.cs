#pragma checksum "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbcefe4b5098287946d60dfe12f0ec85dc1d05ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Khachhang_LietKeKH), @"mvc.1.0.view", @"/Areas/Admin/Views/Khachhang/LietKeKH.cshtml")]
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
#line 1 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\_ViewImports.cshtml"
using Lollipop_boutique;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\_ViewImports.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbcefe4b5098287946d60dfe12f0ec85dc1d05ee", @"/Areas/Admin/Views/Khachhang/LietKeKH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abc694818fac65187b9cb4275eddd0e963ee043d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Khachhang_LietKeKH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lollipop_boutique.Areas.Admin.Models.Khachhang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/DSKhachHang.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn_update_customer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn_delete_customer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn_info_customer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
  
    ViewData["Title"] = "Customer List";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbcefe4b5098287946d60dfe12f0ec85dc1d05ee5456", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""card-header""><h3>Quản lý khách hàng</h3></div>
    <div id=""test""></div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-10"">
            <h2 class=""title_customer"" style=""margin-left:46%"">Customer List</h2>    
");
            WriteLiteral(@"
            <table class=""table"" style=""width:100%;margin-left:10%; text-align:center"">
                <thead class=""thead-dark"">
                    <tr style=""color:blue"">
                        <th style=""width:150px"">Mã khách hàng</th>
                        <th style=""width:400px"">Tên khách hàng</th>
                        <th style=""width:250px"">Ngày sinh</th>
                        <th style=""width:400px"">Địa chỉ</th>
                        <th style=""width:250px"">Giới tính</th>
                        <th style=""width:350px"">Số điện thoại</th>
                        <th style=""width:350px"">Loại khách hàng</th>
                        <th style=""width:150px"">Chức năng</th>
                        <th style=""width:250px"">Đơn hàng</th>
                    </tr>
                </thead>
                <tbody class=""thead-light"">
");
#nullable restore
#line 37 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr id=\"hehe\">\r\n                            <td>\r\n                                ");
#nullable restore
#line 41 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
                           Write(item.MaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 44 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
                           Write(item.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 47 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
                           Write(item.NgaySinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 50 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
                           Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
                           Write(item.GioiTinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
                           Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
                           Write(item.LoaiKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>                            \r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbcefe4b5098287946d60dfe12f0ec85dc1d05ee10746", async() => {
                WriteLiteral("<i class=\"fas fa-pencil-alt icon_update_customer\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2846, "~/Admin/Khachhang/ViewKhachHang?MaKH=", 2846, 37, true);
#nullable restore
#line 62 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
AddHtmlAttributeValue("", 2883, item.MaKH, 2883, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbcefe4b5098287946d60dfe12f0ec85dc1d05ee12480", async() => {
                WriteLiteral("<i class=\"fas fa-user-times icon_delete_customer\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3040, "~/Admin/Khachhang/DeleteKhachHang?MaKH=", 3040, 39, true);
#nullable restore
#line 63 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
AddHtmlAttributeValue("", 3079, item.MaKH, 3079, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbcefe4b5098287946d60dfe12f0ec85dc1d05ee14289", async() => {
                WriteLiteral("<i class=\"fas fa-shopping-cart icon_info_customer\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3304, "~/Admin/dondathang/ViewOrder_Product?MaKH=", 3304, 42, true);
#nullable restore
#line 66 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
AddHtmlAttributeValue("", 3346, item.MaKH, 3346, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\Khachhang\LietKeKH.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
            WriteLiteral(@"</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script>
    $(document).ready(function () {
        $("".btn_delete_customer"").click(function () {
            console.log ('Da vao click');    
            var id =$('#idcustomer').val();
            var ten = $('#namecustomer').val();
            var date = $('#datepicker').val();
            var address = $('#addresscustomer').val();
            var gender = $('#gendercustomer').val();
            var phone =$('#phonecustomer').val();
            var type =$('#typecustomer').val();
            console.log(id,ten, date, address, gender, phone, type);
            $.ajax({
                url: '/Admin/Khachhang/DeleteKhachHang',
                method: ""GET"",
                data: {MaKH:id, TenKH:ten, NgaySinh : date, DiaChi :address, GioiTinh:gender,  SoDienThoai:phone, LoaiKH:type},
                success: function (data) {                   
                    location.href=""/Admin/khachhang");
            WriteLiteral(@"/LietKeKH"";
                    alert(""Delete Customer Successful"");
                    //$('#test').attr(""class"",""alert alert-success"");
                    //$('#test').html('Da Them thanh cong');
                    //console.log(""dang LietKeKH"");
                },
                error: function (data) {
                    alert('Error');
                }
            });
          
        });      
        
        
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lollipop_boutique.Areas.Admin.Models.Khachhang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
