#pragma checksum "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\Shared\PartialViews\_StatusPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e9a70a7eeac6277078e7836affa5427e8ac4c81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_PartialViews__StatusPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/PartialViews/_StatusPartial.cshtml")]
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
#line 1 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.BrandViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.CategoryViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.CommentReactionViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ProductCommentViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ProductDetailViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ProductImageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ProductPropertyViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.ShippingSettingViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.UserDetailViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.User.Models.OrderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Areas.User.Models.ShipmentInfoViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Web.UI.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CommercialSite.Common.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9a70a7eeac6277078e7836affa5427e8ac4c81", @"/Areas/Admin/Views/Shared/PartialViews/_StatusPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b41a3d6aaf0b3d2a247bd12a863e0d484fd18f07", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_PartialViews__StatusPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Status>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\Shared\PartialViews\_StatusPartial.cshtml"
 switch (Model)
{
    case Status.None:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"badge badge-primary\">İşlem Yapılmadı</span>\r\n");
#nullable restore
#line 7 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\Shared\PartialViews\_StatusPartial.cshtml"
        break;
    case Status.Active:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"badge badge-primary\">Aktif</span>\r\n");
#nullable restore
#line 10 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\Shared\PartialViews\_StatusPartial.cshtml"
        break;
    case Status.Deleted:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"badge badge-danger\">Silindi</span>\r\n");
#nullable restore
#line 13 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\Shared\PartialViews\_StatusPartial.cshtml"
        break;
    case Status.Updated:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"badge badge-info\">Güncellendi</span>\r\n");
#nullable restore
#line 16 "C:\Yazılım\CommercialSite\CommercialSite.Web.UI\Areas\Admin\Views\Shared\PartialViews\_StatusPartial.cshtml"
        break;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Status> Html { get; private set; }
    }
}
#pragma warning restore 1591
