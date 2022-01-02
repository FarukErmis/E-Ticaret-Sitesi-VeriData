using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class Order : CoreEntity 
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid OrderInfoId { get; set; }
        public OrderInfo OrderInfo { get; set; }

        public User CreatedUserOrder { get; set; }
        public User UpdatedUserOrder { get; set; }
    }
}
