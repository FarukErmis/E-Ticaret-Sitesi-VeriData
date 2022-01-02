using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.DTOs.OrderInfo;
using CommercialSite.Common.DTOs.Product;
using CommercialSite.Common.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.Order
{
    public class OrderResponse : BaseDto
    {
        public Guid ProductId { get; set; }
        public ProductResponse Product { get; set; }

        public Guid UserId { get; set; }
        public UserResponse User { get; set; }

        public Guid OrderInfoId { get; set; }
        public OrderInfoResponse OrderInfo { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
