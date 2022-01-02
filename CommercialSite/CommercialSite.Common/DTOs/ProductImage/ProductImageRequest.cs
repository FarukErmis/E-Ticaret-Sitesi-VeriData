using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.ProductImage
{
    public class ProductImageRequest : BaseDto
    {
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; }
    }
}
