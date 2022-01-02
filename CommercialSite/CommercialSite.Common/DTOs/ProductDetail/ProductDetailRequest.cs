using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.ProductDetail
{
    public class ProductDetailRequest : BaseDto
    {
        public Guid ProductId { get; set; }
        public Guid ProductCommentId { get; set; }
        public Guid ProductPropertyId { get; set; }
        public Guid ProductImageId { get; set; }
        public Guid ShippingSettingId { get; set; }
    }
}
