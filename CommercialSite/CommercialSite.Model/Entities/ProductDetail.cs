using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class ProductDetail : CoreEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid ProductCommentId { get; set; }
        public ProductComment ProductComment { get; set; }

        public Guid ProductPropertyId { get; set; }
        public ProductProperty ProductProperty { get; set; }

        public Guid ProductImageId { get; set; }
        public ProductImage ProductImage { get; set; }

        public Guid ShippingSettingId { get; set; }
        public ShippingSetting ShippingSetting { get; set; }

        public User CreatedUserProductDetail { get; set; }
        public User UpdatedUserProductDetail { get; set; }
    }
}
