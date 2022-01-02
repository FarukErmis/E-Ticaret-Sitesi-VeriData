using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.DTOs.ProductImage;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.Product
{
    public class ProductRequest : BaseDto
    {
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double WithoutDiscountPrice { get; set; }
        public double? DiscountPrice { get; set; }
        public int? Rate { get; set; }
        public int? ReviewNumber { get; set; }
    }
}
