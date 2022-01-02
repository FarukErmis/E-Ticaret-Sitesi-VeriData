using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.Brand
{
    public class BrandResponse : BaseDto
    {
        public string BrandName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
