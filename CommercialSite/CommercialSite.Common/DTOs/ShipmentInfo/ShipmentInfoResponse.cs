using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.ShipmentInfo
{
    public class ShipmentInfoResponse : BaseDto
    {
        public string ShipmentName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
