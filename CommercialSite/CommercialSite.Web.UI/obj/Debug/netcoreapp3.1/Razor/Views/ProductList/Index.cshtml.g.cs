#pragma checksum "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9cb220f3ae86b2e493a05efa033aa7ecff0df39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductList_Index), @"mvc.1.0.view", @"/Views/ProductList/Index.cshtml")]
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
#line 1 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.BrandViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.CategoryViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.CommentReactionViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ProductCommentViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ProductDetailViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ProductImageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ProductPropertyViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ShippingSettingViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.UserDetailViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.User.Models.FavoriteProductViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9cb220f3ae86b2e493a05efa033aa7ecff0df39", @"/Views/ProductList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d19b9b85ec87795e58c38cf3c3e9956aa07eb459", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/my-css/ProductList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right btnCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-abc", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Sepete Ekle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9cb220f3ae86b2e493a05efa033aa7ecff0df399974", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9cb220f3ae86b2e493a05efa033aa7ecff0df3911088", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"offset-1 col-lg-2\">\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"col-lg-8\">\r\n            <div class=\"row\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 108 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                         foreach (ProductViewModel item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4\">\r\n                                <figure class=\"card card-product-grid card-lg\" style=\"width:300px;\">\r\n                                    <div");
            BeginWriteAttribute("id", " id=\"", 5717, "\"", 5752, 1);
#nullable restore
#line 112 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
WriteAttributeValue("", 5722, Url.Content($"demo{item.Id}"), 5722, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"carousel slide\" data-ride=\"carousel\">\r\n\r\n                                        <!-- Indicators -->\r\n                                        <ul class=\"carousel-indicators\" id=\"data-slide\">\r\n");
#nullable restore
#line 116 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                             for (int k = 0; k < item.ProductImages.Where(x => x.ProductId == item.Id).ToList().Count(); k++)
                                            {
                                                if (k != 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li data-target=\"");
#nullable restore
#line 120 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                Write(Url.Content($"#demo{item.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"");
#nullable restore
#line 120 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                                                                Write(k);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 121 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li data-target=\"");
#nullable restore
#line 124 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                Write(Url.Content($"#demo{item.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"");
#nullable restore
#line 124 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                                                                Write(k);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 125 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ul>\r\n                                        <!-- The slideshow -->\r\n                                        <div class=\"carousel-inner\" id=\"productList\">\r\n\r\n");
#nullable restore
#line 131 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                             for (int k = 0; k < item.ProductImages.Where(x => x.ProductId == item.Id).ToList().Count(); k++)
                                            {
                                                if (k != 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"carousel-item\" data-abc=\"true\">\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 7437, "\"", 7527, 1);
#nullable restore
#line 136 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
WriteAttributeValue("", 7444, Url.Action("Index","ProductDetail",new { name = item.ProductName , id = item.Id }), 7444, 83, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <img");
            BeginWriteAttribute("src", " src=\'", 7595, "\'", 7696, 1);
#nullable restore
#line 137 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
WriteAttributeValue("", 7601, Url.Content($"~/Upload/ProductImages/{item.ProductImages.Select(x=> x.ImageUrl).ToList()[k]}"), 7601, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7697, "\"", 7761, 1);
#nullable restore
#line 137 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
WriteAttributeValue("", 7703, Url.Content($"~/Upload/ProductImages/{item.ProductName}"), 7703, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                        </a>\r\n                                                    </div>\r\n");
#nullable restore
#line 140 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"carousel-item active \" data-abc=\"true\">\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 8208, "\"", 8296, 1);
#nullable restore
#line 144 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
WriteAttributeValue("", 8215, Url.Action("Index","ProductDetail",new { name = item.ProductName, id = item.Id}), 8215, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <img");
            BeginWriteAttribute("src", " src=\'", 8364, "\'", 8465, 1);
#nullable restore
#line 145 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
WriteAttributeValue("", 8370, Url.Content($"~/Upload/ProductImages/{item.ProductImages.Select(x=> x.ImageUrl).ToList()[k]}"), 8370, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8466, "\"", 8530, 1);
#nullable restore
#line 145 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
WriteAttributeValue("", 8472, Url.Content($"~/Upload/ProductImages/{item.ProductName}"), 8472, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                        </a>\r\n                                                    </div>\r\n");
#nullable restore
#line 148 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                }

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                    <figcaption class=\"info-wrap\">\r\n                                        <div class=\"row\">\r\n");
#nullable restore
#line 155 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                             if (item.ProductName.Length < 20)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"col-md-7\" id=\"productTitle\"> <a");
            BeginWriteAttribute("href", " href=\"", 9195, "\"", 9259, 1);
#nullable restore
#line 157 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
WriteAttributeValue("", 9202, Url.Action("Index","ProductDetail",new { id = item.Id }), 9202, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"title\" data-abc=\"true\">");
#nullable restore
#line 157 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                                                                                                                                      Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</a> </div>\r\n");
#nullable restore
#line 158 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"col-md-7\" id=\"productTitle\"> <a");
            BeginWriteAttribute("href", " href=\"", 9560, "\"", 9624, 1);
#nullable restore
#line 161 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
WriteAttributeValue("", 9567, Url.Action("Index","ProductDetail",new { id = item.Id }), 9567, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"title\" data-abc=\"true\">");
#nullable restore
#line 161 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                                                                                                                                      Write(item.ProductName.Substring(0, 20));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</a> </div>\r\n");
#nullable restore
#line 162 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"col-md-5\">\r\n                                                <div class=\"rating text-right\" id=\"productRate\">\r\n");
#nullable restore
#line 165 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                     for (int i = 0; i < 5; i++)
                                                    {
                                                        if (item.Rate > i + 0.5)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <i class=\"bi bi-star-fill\"></i>\r\n");
#nullable restore
#line 170 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                        }
                                                        else if (item.Rate == i + 0.5)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <i class=\"bi bi-star-half\"></i>\r\n");
#nullable restore
#line 174 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <i class=\"bi bi-star\"></i>\r\n");
#nullable restore
#line 178 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                        }
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>
                                            </div>
                                        </div>
                                    </figcaption>
                                    <div class=""bottom-wrap"">
                                        <div class=""row"">
                                            <div class=""col-4 float-left"">
");
#nullable restore
#line 187 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                 if (item.WithoutDiscountPrice == null
                                                   )
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <p class=\"font-italic\" style=\"font-size:16px;margin-top:20px;text-decoration:none;font-weight:bolder;color:green;\" id=\"fakePrice\">");
#nullable restore
#line 190 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                                                                                                                                 Write(item.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</p>\r\n");
#nullable restore
#line 191 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <p class=\"font-italic\" id=\"fakePrice\">");
#nullable restore
#line 194 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                                     Write(item.WithoutDiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</p>\r\n                                                    <p class=\"font-italic\" id=\"truePrice\">");
#nullable restore
#line 195 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                                     Write(item.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</p>\r\n");
#nullable restore
#line 196 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                            <div class=""col-8 ""style=""padding-left:150px; padding-right:20px;"">
                                                <div class=""row"">
                                                    <div class=""col-lg-6"" id=""buyQuick"" >
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9cb220f3ae86b2e493a05efa033aa7ecff0df3928956", async() => {
                WriteLiteral(" Sepete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 203 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 204 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                       WriteLiteral(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 205 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                    WriteLiteral(item.Brand.BrandName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brandName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-brandName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brandName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 206 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                      WriteLiteral(item.ProductName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 207 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                   WriteLiteral(item.ProductImages.Select(x=>x.ImageUrl).FirstOrDefault());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["imageUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-imageUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["imageUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 208 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                               WriteLiteral(item.WithoutDiscountPrice);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["withoutDiscountPrice"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-withoutDiscountPrice", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["withoutDiscountPrice"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 209 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                                        WriteLiteral(item.DiscountPrice);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["discountPrice"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-discountPrice", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["discountPrice"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 210 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                                                               WriteLiteral(item.Rate);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-rate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    </div>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </figure>
                            </div>
");
#nullable restore
#line 220 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(\".btnCart\").click(function () {\r\n            var id = $(this).attr(\"id\");\r\n            $.ajax({\r\n                type: \"GET\",\r\n                dataType: \"JSON\",\r\n                url: \"");
#nullable restore
#line 236 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Views\ProductList\Index.cshtml"
                 Write(Url.Action("Add","ShoppingCart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/"" + id,
                success: function (result) {
                    console.log(result);
                },
                error: function (result) {
                    console.log(result);
                }
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591