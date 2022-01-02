using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.ProductProperty
{
    public class ProductPropertyRequest : BaseDto
    {
        public Guid ProductId { get; set; }
        public string VarKey { get; set; }
        public string VarValue { get; set; }
    }
}
