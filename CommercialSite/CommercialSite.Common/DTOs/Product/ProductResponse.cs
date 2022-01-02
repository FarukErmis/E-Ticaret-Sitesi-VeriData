using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.DTOs.Brand;
using CommercialSite.Common.DTOs.Category;
using CommercialSite.Common.DTOs.ProductComment;
using CommercialSite.Common.DTOs.ProductImage;
using CommercialSite.Common.DTOs.ProductProperty;
using CommercialSite.Common.DTOs.ShippingSetting;
using System;
using System.Collections.Generic;

namespace CommercialSite.Common.DTOs.Product
{
    public class ProductResponse : BaseDto
    {
        public ProductResponse()
        {
            ProductImages = new HashSet<ProductImageResponse>();
            ProductProperties = new HashSet<ProductPropertyResponse>();
            ProductComments = new HashSet<ProductCommentResponse>();
            ShippingSettings = new HashSet<ShippingSettingResponse>();
        }
        public Guid CategoryId { get; set; }
        public CategoryResponse Category { get; set; }
        public Guid BrandId { get; set; }
        public BrandResponse Brand { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double WithoutDiscountPrice { get; set; }
        public double? DiscountPrice { get; set; }
        public int? Rate { get; set; }
        public int? ReviewNumber { get; set; }
        public DateTime? CreatedDate { get; set; }

        //Gördünmü hatayı isimleri aynı değildi
        public ICollection<ProductImageResponse> ProductImages { get; set; }
        public ICollection<ProductPropertyResponse> ProductProperties { get; set; }
        public ICollection<ProductCommentResponse> ProductComments { get; set; }
        public ICollection<ShippingSettingResponse> ShippingSettings { get; set; }
    }
}
