#pragma checksum "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fa611d0e9b67eebeb4492e5264702bcf6f87733"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanpham_Index), @"mvc.1.0.view", @"/Views/Sanpham/Index.cshtml")]
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
#line 1 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa611d0e9b67eebeb4492e5264702bcf6f87733", @"/Views/Sanpham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32245f2a035dda76030e7fe1b4cad468586c06eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
   List<string> list_HA = (List<string>)ViewBag.HinhAnhSP; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
   ViewData["Title"] = "Index" ;
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""/assets/images/slider/bg/background2.png"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h1 class=""breadcrumb-heading"">Lollipop Boutique</h1>
                        <ul>
                            <li>Danh sách sản phẩm</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""shop-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
              
                <div class=""col-lg-1 order-lg-1 order-2 pt-10 pt-lg-0""></div>
                <div class=""col-lg-11 order-lg-2 order-1"">
                    <div class=""product-topbar"">
                        <ul>
                            <li class=""product-view-wrap"">
                             ");
            WriteLiteral(@"   <ul class=""nav"" role=""tablist"">
                                    <li class=""grid-view"" role=""presentation"">
                                        <a id=""grid-view-tab"" data-bs-toggle=""tab"" href=""#grid-view"" role=""tab"" aria-selected=""true"">
                                            <i class=""fa fa-th""></i>
                                        </a>
                                    </li>
                                    <li class=""list-view"" role=""presentation"">
                                        <a class=""active"" id=""list-view-tab"" data-bs-toggle=""tab"" href=""#list-view"" role=""tab"" aria-selected=""true"">
                                            <i class=""fa fa-th-list""></i>
                                        </a>
                                    </li>
                                </ul>
                            </li>
                            
                            <li class=""short"">
");
            WriteLiteral("                            </li>\n                        </ul>\n                    </div>\n                    <div class=\"tab-content text-charcoal pt-8\">\n                        <div class=\"product-grid-view row\">\n");
#nullable restore
#line 59 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
                               var stt = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
                             foreach (var item in (List<Sanpham>)Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-3 col-sm-6\">\n                            <div class=\"product-item\">\n                                <div class=\"product-img img-zoom-effect\">\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3354, "\"", 3392, 2);
            WriteAttributeValue("", 3361, "SanPham/Details?masp=", 3361, 21, true);
#nullable restore
#line 65 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 3382, item.MaSp, 3382, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                        <img class=\"img-full\"");
            BeginWriteAttribute("src", " src=\"", 3456, "\"", 3475, 1);
#nullable restore
#line 66 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 3462, list_HA[stt], 3462, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product Images\">\n                                    </a>\n                                    <div class=\"product-add-action\">\n                                        <ul>\n                                            <li>\n");
#nullable restore
#line 71 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
                                                   stt += 1;
                                                                    var id_add = "add_cart" + @stt.ToString(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fa611d0e9b67eebeb4492e5264702bcf6f877338538", async() => {
                WriteLiteral("\n                                                    <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4071, "\"", 4125, 3);
                WriteAttributeValue("", 4081, "document.getElementById(\'", 4081, 25, true);
#nullable restore
#line 74 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 4106, id_add, 4106, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4113, "\').submit();", 4113, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\n                                                        <i class=\"pe-7s-cart\"></i>\n                                                    </a>\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3939, "/GioHang/Add_cart?product_id=", 3939, 29, true);
#nullable restore
#line 73 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
AddHtmlAttributeValue("", 3968, item.MaSp, 3968, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 73 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
AddHtmlAttributeValue("", 3998, id_add, 3998, 7, false);

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
            WriteLiteral(@"
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                                <div class=""product-content"">
                                    <a class=""product-name"" href=""single-product.html"">");
#nullable restore
#line 83 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
                                                                                  Write(item.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                    <div class=\"price-box pb-1\">\n                                        <span class=\"new-price text-danger\">");
#nullable restore
#line 85 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
                                                                       Write(item.GiaTien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\n                                    </div>\n                                </div>\n                            </div>\n                        </div>            ");
#nullable restore
#line 89 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\Index.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>
                             
                </div>
                        
            </div>
                        
                    
        </div>
                                

                           
    </div>

                     


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {


            $(""#giasanpham"").keyup(function () {
                var strkeyword = $('#giasanpham').val();
                $.ajax({
                    url: '/Searchtheogia/Searchgia/',
                    datatype: ""json"",
                    type: ""POST"",
                    data: { giasanpham: strkeyword },
                    async: true,
                    success: function (results) {
                        $(""#gia1"").html("""");
                        $(""#gia1"").html(results);

                    },
                    error: function (xhr) {
                        alert('error');
                    }
                });
            });
        });
    </script>
");
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
