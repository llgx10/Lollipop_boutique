#pragma checksum "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dcdc27aee2ac4569341b0d461b50692625f4b01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Searchtheogia_ListTheoGia), @"mvc.1.0.view", @"/Views/Searchtheogia/ListTheoGia.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dcdc27aee2ac4569341b0d461b50692625f4b01", @"/Views/Searchtheogia/ListTheoGia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32245f2a035dda76030e7fe1b4cad468586c06eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Searchtheogia_ListTheoGia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
 if (Model != null && Model.Count() > 0)

{
    var stt = 0;

    foreach (var item in Model)

    {
        string url = $"/{item.MaSp}.html";



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4 col-sm-6\">\n            <div class=\"product-item\">\n                <div class=\"product-img img-zoom-effect\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 326, "\"", 337, 1);
#nullable restore
#line 16 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
WriteAttributeValue("", 333, url, 333, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 17 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
                          
                            string temp = item.MaSp + ".jpg";
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"img-full\"");
            BeginWriteAttribute("src", " src=\"", 500, "\"", 518, 2);
            WriteAttributeValue("", 506, "/Image/", 506, 7, true);
#nullable restore
#line 20 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
WriteAttributeValue("", 513, temp, 513, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 519, "\"", 535, 1);
#nullable restore
#line 20 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
WriteAttributeValue("", 525, item.MoTa, 525, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    </a>\n                    <div class=\"product-add-action\">\n                        <ul>\n                            <li>\n");
#nullable restore
#line 25 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
                                  
                                    stt += 1;
                                    var id_add = "add_cart" + @stt.ToString();
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dcdc27aee2ac4569341b0d461b50692625f4b016897", async() => {
                WriteLiteral("\n                                    <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1034, "\"", 1088, 3);
                WriteAttributeValue("", 1044, "document.getElementById(\'", 1044, 25, true);
#nullable restore
#line 30 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
WriteAttributeValue("", 1069, id_add, 1069, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1076, "\').submit();", 1076, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\n                                        <i class=\"pe-7s-cart\"></i>\n                                    </a>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 918, "/GioHang/Add_cart?product_id=", 918, 29, true);
#nullable restore
#line 29 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
AddHtmlAttributeValue("", 947, item.MaSp, 947, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
AddHtmlAttributeValue("", 977, id_add, 977, 7, false);

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
            WriteLiteral("\n                            </li>\n\n                        </ul>\n                    </div>\n                </div>\n                <div class=\"product-content\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dcdc27aee2ac4569341b0d461b50692625f4b0110290", async() => {
#nullable restore
#line 40 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
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
            WriteLiteral("\n                    <div class=\"price-box pb-1\">\n                        <span class=\"new-price\">");
#nullable restore
#line 42 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"
                                           Write(item.GiaTien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\n                    </div>\n");
            WriteLiteral("                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 56 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Searchtheogia\ListTheoGia.cshtml"

    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
