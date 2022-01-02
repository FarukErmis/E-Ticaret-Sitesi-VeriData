using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.ShippingSetting
{
    public class ShippingSettingRequest : BaseDto
    {
        public Guid ProductId { get; set; }
        public bool IsShippingFree { get; set; }
    }
}
