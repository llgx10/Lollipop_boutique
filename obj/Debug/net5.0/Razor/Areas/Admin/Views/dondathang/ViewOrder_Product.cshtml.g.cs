#pragma checksum "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60a5c51ffada578daf9164fe238823906cef35ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_dondathang_ViewOrder_Product), @"mvc.1.0.view", @"/Areas/Admin/Views/dondathang/ViewOrder_Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a5c51ffada578daf9164fe238823906cef35ef", @"/Areas/Admin/Views/dondathang/ViewOrder_Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abc694818fac65187b9cb4275eddd0e963ee043d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_dondathang_ViewOrder_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lollipop_boutique.Areas.Admin.Models.dondathang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/ViewOrderProduct.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Khachhang/LietKeKH"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:2%; margin-left:10%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
  
    ViewData["Title"] = "Order List";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "60a5c51ffada578daf9164fe238823906cef35ef5563", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60a5c51ffada578daf9164fe238823906cef35ef6677", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Bootstrap 4 DatePicker</title>
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous""/>
    <script src=""https://unpkg.com/gijgo@1.9.13/js/gijgo.min.js"" type=""text/javascript""></script>
    <link href=""https://unpkg.com/gijgo@1.9.13/css/gijgo.min.css"" rel=""stylesheet"" type=""text/css"" />   
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" 
<div class=""card-header""><h3>Danh sách đơn hàng</h3></div>
    <div id=""test""></div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-10"">
            <h2 class=""title_customer"" style=""margin-left:46%"">List Order</h2>      
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60a5c51ffada578daf9164fe238823906cef35ef8588", async() => {
                WriteLiteral("Quay lại");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div id=""body_viewOrder"">
                <table class=""table"" style=""width:100%; margin-left:10%; text-align:center"">
                <tr>
                    <th>Mã đơn hàng</th>
                    <th>Giá trị</th>
                    <th>Giảm giá</th>
                    <th>Thành tiền</th>
                    <th>Tên người nhận</th>
                    <th>Số điện thoại người nhận</th>
                    <th>Địa chỉ</th>
                    <th>Trạng thái</th>
                </tr>
");
#nullable restore
#line 36 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr id=\"table_ViewOrder\">\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                   Write(item.MaDDH);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                   Write(item.TongDonHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>                    \r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                   Write(item.SoTienGiam);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                   Write(item.ThanhTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                   Write(item.TENNGUOINHAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                   Write(item.SDTNGUOINHAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                   Write(item.DIACHINHAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                     <td>\r\n");
#nullable restore
#line 61 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                          if( @item.TINHTRANGDONHANG == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a  style=\"color:white\" class=\"btn btn-primary\">Đang chuẩn bị</a>\r\n");
#nullable restore
#line 64 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                                    }
                                 else if( @item.TINHTRANGDONHANG == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a  style=\"color:white\"class=\"btn btn-info\">Đang giao</a>\r\n");
#nullable restore
#line 68 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                                    }
                                 else if( @item.TINHTRANGDONHANG == 2)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a  style=\"color:white\"class=\"btn btn-success\">Đã giao</a>\r\n");
#nullable restore
#line 72 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                                    }       

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 75 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\dondathang\ViewOrder_Product.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            </div>      \r\n        </div>\r\n     </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lollipop_boutique.Areas.Admin.Models.dondathang>> Html { get; private set; }
    }
}
#pragma warning restore 1591