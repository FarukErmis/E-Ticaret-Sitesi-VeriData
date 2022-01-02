using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.DTOs.Product;
using CommercialSite.Common.DTOs.ProductComment;
using CommercialSite.Common.DTOs.ProductImage;
using CommercialSite.Common.DTOs.ProductProperty;
using CommercialSite.Common.DTOs.ShippingSetting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.ProductDetail
{
    public class ProductDetailResponse : BaseDto
    {
        public Guid ProductId { get; set; }
        public ProductResponse Product { get; set; }
        public Guid ProductCommentId { get; set; }
        public ProductCommentResponse ProductComment { get; set; }
        public Guid ProductPropertyId { get; set; }
        public ProductPropertyResponse ProductProperty { get; set; }
        public Guid ProductImageId { get; set; }
        public ProductImageResponse ProductImage { get; set; }
        public Guid ShippingSettingId { get; set; }
        public ShippingSettingResponse ShippingSetting { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
