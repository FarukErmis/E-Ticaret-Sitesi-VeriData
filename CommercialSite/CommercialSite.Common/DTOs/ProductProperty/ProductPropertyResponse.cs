using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.ProductProperty
{
    public class ProductPropertyResponse : BaseDto
    {
        public Guid ProductId { get; set; }
        public string VarKey { get; set; }
        public string VarValue { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
