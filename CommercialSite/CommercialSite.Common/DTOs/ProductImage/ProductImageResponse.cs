using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.ProductImage
{
    public class ProductImageResponse : BaseDto
    {
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
