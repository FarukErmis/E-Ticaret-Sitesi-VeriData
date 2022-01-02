using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.Order
{
    public class OrderRequest : BaseDto
    {
        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }

        public Guid OrderInfoId { get; set; }
    }
}
