using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductCommentViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductImageViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductPropertyViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ShippingSettingViewModels;
using System;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ProductDetailViewModels
{
    public class ProductDetailViewModel
    {
        public Guid ProductId { get; set; }
        public ProductViewModel Product { get; set; }
        public Guid ProductCommentId { get; set; }
        public ProductCommentViewModel ProductComment { get; set; }
        public Guid ProductPropertyId { get; set; }
        public ProductPropertyViewModel ProductProperty { get; set; }
        public Guid ProductImageId { get; set; }
        public ProductImageViewModel ProductImage { get; set; }
        public Guid ShippingSettingId { get; set; }
        public ShippingSettingViewModel ShippingSetting { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
