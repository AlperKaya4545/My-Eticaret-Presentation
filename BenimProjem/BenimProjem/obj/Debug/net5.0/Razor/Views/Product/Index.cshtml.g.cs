#pragma checksum "C:\Users\ALPER\Desktop\deneme\BenimProjem\BenimProjem\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19a3ef80929b51730a27a7ae6a7ebdd9aa7392fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\ALPER\Desktop\deneme\BenimProjem\BenimProjem\Views\_ViewImports.cshtml"
using BenimProjem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ALPER\Desktop\deneme\BenimProjem\BenimProjem\Views\_ViewImports.cshtml"
using BenimProjem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19a3ef80929b51730a27a7ae6a7ebdd9aa7392fa", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dcf4c9de421be6d99c17ceeb6ed7f92877bc993", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-quantity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ALPER\Desktop\deneme\BenimProjem\BenimProjem\Views\Product\Index.cshtml"
  
    Layout = "_ProductLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""breadcrumb-content"">
            <ul>
                <li><a href=""index.html"">Home</a></li>
                <li class=""active"">Single Product Normal</li>
            </ul>
        </div>
    </div>
</div>
<!-- Li's Breadcrumb Area End Here -->
<!-- content-wraper start -->
<div class=""content-wraper"">
    <div class=""container"">
        <div class=""row single-product-area"">
            <div class=""col-lg-5 col-md-6"">
                <!-- Product Details Left -->
                <div class=""product-details-left"">
                    <div class=""product-details-images slider-navigation-1"">
");
#nullable restore
#line 24 "C:\Users\ALPER\Desktop\deneme\BenimProjem\BenimProjem\Views\Product\Index.cshtml"
                         foreach (var item in Model.Images)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <div class=\"lg-image\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 925, "\"", 961, 2);
            WriteAttributeValue("", 931, "/product/large-size/", 931, 20, true);
#nullable restore
#line 27 "C:\Users\ALPER\Desktop\deneme\BenimProjem\BenimProjem\Views\Product\Index.cshtml"
WriteAttributeValue("", 951, item.Name, 951, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product image\">\r\n                        </div>\n");
#nullable restore
#line 29 "C:\Users\ALPER\Desktop\deneme\BenimProjem\BenimProjem\Views\Product\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        
                       
                    </div>                   
                </div>
                <!--// Product Details Left -->
            </div>

            <div class=""col-lg-7 col-md-6"">
                <div class=""product-details-view-content sp-normal-content pt-60"">
                    <div class=""product-info"">
                        <h2>");
#nullable restore
#line 40 "C:\Users\ALPER\Desktop\deneme\BenimProjem\BenimProjem\Views\Product\Index.cshtml"
                       Write(Model.ProductDetail.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span class=""product-details-ref"">Reference: demo_15</span>
                        <div class=""rating-box pt-20"">
                            <ul class=""rating rating-with-review-item"">
                                <li><i class=""fa fa-star-o""></i></li>
                                <li><i class=""fa fa-star-o""></i></li>
                                <li><i class=""fa fa-star-o""></i></li>
                                <li class=""no-star""><i class=""fa fa-star-o""></i></li>
                                <li class=""no-star""><i class=""fa fa-star-o""></i></li>
                                <li class=""review-item""><a href=""#"">Read Review</a></li>
                                <li class=""review-item""><a href=""#"">Write Review</a></li>
                            </ul>
                        </div>
                        <div class=""price-box pt-20"">
                            <span class=""new-price new-price-2"">");
#nullable restore
#line 54 "C:\Users\ALPER\Desktop\deneme\BenimProjem\BenimProjem\Views\Product\Index.cshtml"
                                                           Write(Model.ProductDetail.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"product-desc\">\r\n                            <p>\r\n                                <span>\r\n                                    ");
#nullable restore
#line 59 "C:\Users\ALPER\Desktop\deneme\BenimProjem\BenimProjem\Views\Product\Index.cshtml"
                               Write(Model.ProductDetail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"single-add-to-cart\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19a3ef80929b51730a27a7ae6a7ebdd9aa7392fa8582", async() => {
                WriteLiteral(@"
                                <div class=""quantity"">
                                    <label>Quantity</label>
                                    <div class=""cart-plus-minus"">
                                        <input class=""cart-plus-minus-box"" value=""1"" type=""text"">
                                        <div class=""dec qtybutton""><i class=""fa fa-angle-down""></i></div>
                                        <div class=""inc qtybutton""><i class=""fa fa-angle-up""></i></div>
                                    </div>
                                </div>
                                <button class=""add-to-cart""  type=""submit"">Add to cart</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
