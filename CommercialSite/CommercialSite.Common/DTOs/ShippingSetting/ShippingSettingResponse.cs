using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.ShippingSetting
{
    public class ShippingSettingResponse : BaseDto
    {
        public Guid ProductId { get; set; }
        public bool IsShippingFree { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
