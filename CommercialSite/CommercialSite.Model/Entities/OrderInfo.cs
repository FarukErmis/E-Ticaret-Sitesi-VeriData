using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class OrderInfo : CoreEntity
    {
        public OrderInfo()
        {
            Orders = new HashSet<Order>();
        }
        public string ShippingFirstName { get; set; }
        public string ShippingSurname { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingPhoneNumber { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingLocation { get; set; }
        public string ShippingSubLocation { get; set; }
        public string ShippingEmail { get; set; }
        public string BillingFirstName { get; set; }
        public string BillingSurname { get; set; }
        public string BillingAddress { get; set; }
        public string BillingPhoneNumber { get; set; }
        public string BillingCountry { get; set; }
        public string BillingLocation { get; set; }
        public string BillingSubLocation { get; set; }
        public string BillingEmail { get; set; }
        public Guid ShipmentInfoId { get; set; }
        public ShipmentInfo ShipmentInfo { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public User CreatedUserOrderInfo { get; set; }
        public User UpdatedUserOrderInfo { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
