#pragma checksum "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14559c0073ad68dfde802a36913b186d13078c40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanpham_List), @"mvc.1.0.view", @"/Views/Sanpham/List.cshtml")]
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
#line 2 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\_ViewImports.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14559c0073ad68dfde802a36913b186d13078c40", @"/Views/Sanpham/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32245f2a035dda76030e7fe1b4cad468586c06eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<doan.Models.Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sanpham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
  
    Danhmucsp danhmucsp = ViewBag.CurrentCat;

    ViewData["Title"] = danhmucsp.MoTa + " " + ViewBag.CurrentPage;
    Layout = "~/Views/Shared/_Layout.cshtml";
    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = PageCurrent + 1;

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
                        <h1 class=""breadcrumb-heading"">");
#nullable restore
#line 19 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                  Write(danhmucsp.TenDanhMuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <ul>\n                            <li>\n                                <a href=\"/\">Home <i class=\"pe-7s-angle-right\"></i></a>\n                            </li>\n                            <li>");
#nullable restore
#line 24 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                           Write(danhmucsp.TenDanhMuc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""shop-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-1 order-lg-1 order-2 pt-10 pt-lg-0"">
");
            WriteLiteral(@"                </div>
                <div class=""col-lg-11 order-lg-2 order-1"">
                    <div class=""product-topbar"">
                        <ul>
                            <li class=""product-view-wrap"">
                                <ul class=""nav"" role=""tablist"">
                                    <li class=""grid-view"" role=""presentation"">
                                        <a id=""grid-view-tab"" data-bs-toggle=""tab"" href=""#grid-view"" role=""tab"" aria-selected=""true"">
                                            <i class=""fa fa-th""></i>
                                        </a>
                                    </li>
                                    <li class=""list-view"" role=""presentation"">
                                        <a class=""active"" id=""list-view-tab"" data-bs-toggle=""tab"" href=""#list-view"" role=""tab"" aria-selected=""true"">
                                            <i class=""fa fa-th-list""></i>
                                        </a>
                         ");
            WriteLiteral("           </li>\n                                </ul>\n                            </li>\n                            <li class=\"page-count\">\n\n                                <span>Tìm được ");
#nullable restore
#line 273 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                          Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" sản phẩm trong danh mục</span>\n                            </li>\n                            <li class=\"short\">\n");
            WriteLiteral(@"                            </li>
                        </ul>
                    </div>
                    <div class=""tab-content text-charcoal pt-8"">
                        <div class=""tab-pane fade"" id=""grid-view"" role=""tabpanel"" aria-labelledby=""grid-view-tab"">
                            <div class=""product-grid-view row"">
");
#nullable restore
#line 290 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                 if (Model != null && Model.Count() > 0)

                                {
                                    var stt = 0;
                                    foreach (var item in Model)

                                    {
                                        string url = $"/{item.MaSp}.html";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-lg-4 col-sm-6"">
                                            <div class=""product-item"">
                                                <div class=""product-img img-zoom-effect"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 19787, "\"", 19798, 1);
#nullable restore
#line 303 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
WriteAttributeValue("", 19794, url, 19794, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 304 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                          
                                                            string temp = item.MaSp + ".jpg";
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <img class=\"img-full\"");
            BeginWriteAttribute("src", " src=\"", 20089, "\"", 20107, 2);
            WriteAttributeValue("", 20095, "/Image/", 20095, 7, true);
#nullable restore
#line 307 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
WriteAttributeValue("", 20102, temp, 20102, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 20108, "\"", 20124, 1);
#nullable restore
#line 307 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
WriteAttributeValue("", 20114, item.MoTa, 20114, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </a>
                                                    <div class=""product-add-action"">
                                                        <ul>
                                                            <li>
");
#nullable restore
#line 312 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                                  
                                                                    stt += 1;
                                                                    var id_add = "add_cart4" + @stt.ToString();
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14559c0073ad68dfde802a36913b186d13078c4013042", async() => {
                WriteLiteral("\n                                                                    <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 20944, "\"", 20998, 3);
                WriteAttributeValue("", 20954, "document.getElementById(\'", 20954, 25, true);
#nullable restore
#line 317 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
WriteAttributeValue("", 20979, id_add, 20979, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 20986, "\').submit();", 20986, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\n                                                                        <i class=\"pe-7s-cart\"></i>\n                                                                    </a>\n                                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 20796, "/GioHang/Add_cart?product_id=", 20796, 29, true);
#nullable restore
#line 316 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
AddHtmlAttributeValue("", 20825, item.MaSp, 20825, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 316 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
AddHtmlAttributeValue("", 20855, id_add, 20855, 7, false);

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
            WriteLiteral("\n\n                                                            </li>\n");
            WriteLiteral(@"                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class=""product-content"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14559c0073ad68dfde802a36913b186d13078c4016768", async() => {
#nullable restore
#line 342 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                                                            Write(item.TenSp);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                    <div class=\"price-box pb-1\">\n                                                        <span class=\"new-price text-danger\">");
#nullable restore
#line 344 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                                                       Write(item.GiaTien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\n                                                    </div>\n                                                    <div class=\"rating-box\">\n");
            WriteLiteral("                                                    </div>\n                                                </div>\n                                            </div>\n                                        </div>\n");
#nullable restore
#line 358 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"

                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""tab-pane fade show active"" id=""list-view"" role=""tabpanel"" aria-labelledby=""list-view-tab"">
                            <div class=""product-list-view with-sidebar row"">
");
#nullable restore
#line 366 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                 if (Model != null && Model.Count() > 0)
                                {
                                    var stt = 0;
                                    foreach (var item in Model)

                                    {
                                        string url = $"/{item.MaSp}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""col-12 pt-6"">
                                            <div class=""product-item"">
                                                <div class=""product-img img-zoom-effect"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 25049, "\"", 25060, 1);
#nullable restore
#line 376 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
WriteAttributeValue("", 25056, url, 25056, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 377 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                          
                                                            string temp = item.MaSp + ".jpg";
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <img class=\"img-full\"");
            BeginWriteAttribute("src", " src=\"", 25351, "\"", 25369, 2);
            WriteAttributeValue("", 25357, "/Image/", 25357, 7, true);
#nullable restore
#line 380 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
WriteAttributeValue("", 25364, temp, 25364, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 25370, "\"", 25387, 1);
#nullable restore
#line 380 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
WriteAttributeValue(" ", 25376, item.MoTa, 25377, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </a>
                                                    <div class=""product-add-action"">
                                                        <ul>
                                                            <li>
");
#nullable restore
#line 385 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                                  
                                                                    stt += 1;
                                                                    var id_add = "add_cart4" + @stt.ToString();
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14559c0073ad68dfde802a36913b186d13078c4022940", async() => {
                WriteLiteral("\n                                                                    <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 26207, "\"", 26261, 3);
                WriteAttributeValue("", 26217, "document.getElementById(\'", 26217, 25, true);
#nullable restore
#line 390 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
WriteAttributeValue("", 26242, id_add, 26242, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 26249, "\').submit();", 26249, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\n                                                                        <i class=\"pe-7s-cart\"></i>\n                                                                    </a>\n                                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 26059, "/GioHang/Add_cart?product_id=", 26059, 29, true);
#nullable restore
#line 389 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
AddHtmlAttributeValue("", 26088, item.MaSp, 26088, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 389 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
AddHtmlAttributeValue("", 26118, id_add, 26118, 7, false);

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
            WriteLiteral("\n\n                                                            </li>\n");
            WriteLiteral(@"                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class=""product-content align-self-center"">
                                                    <a class=""product-name pb-2""");
            BeginWriteAttribute("href", " href=\"", 27737, "\"", 27748, 1);
#nullable restore
#line 410 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
WriteAttributeValue("", 27744, url, 27744, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h4>");
#nullable restore
#line 410 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                                                            Write(item.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\n                                                    <div class=\"price-box pb-1\">\n                                                        <span class=\"new-price text-danger\">");
#nullable restore
#line 412 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                                                       Write(item.GiaTien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\n                                                    </div>\n");
            WriteLiteral("                                                    <p class=\"short-desc mb-0\">");
#nullable restore
#line 423 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                                          Write(item.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                                </div>\n                                            </div>\n                                        </div>\n");
#nullable restore
#line 427 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                    <div class=\"pagination-area pt-10\">\n                        <ul class=\"pagination justify-content-center\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14559c0073ad68dfde802a36913b186d13078c4029040", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 435 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedListRenderOptions.Bootstrap4PageNumbersOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 435 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspArea = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 435 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Sanpham\List.cshtml"
                                                                                                                                                                            WriteLiteral(danhmucsp.MaDanhMuc);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </ul>\n                    </div>\n");
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</main>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<doan.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
