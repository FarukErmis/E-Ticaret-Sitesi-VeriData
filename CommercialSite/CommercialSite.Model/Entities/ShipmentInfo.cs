using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class ShipmentInfo : CoreEntity
    {
        public ShipmentInfo()
        {
            OrderInfos = new HashSet<OrderInfo>();
        }
        public string ShipmentName { get; set; }

        public User CreatedUserShipmentInfo { get; set; }
        public User UpdatedUserShipmentInfo { get; set; }
        public ICollection<OrderInfo> OrderInfos { get; set; }
    }
}
