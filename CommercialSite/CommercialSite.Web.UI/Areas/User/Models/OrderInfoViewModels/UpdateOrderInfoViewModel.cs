using CommercialSite.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.User.Models.OrderInfoViewModels
{
    public class UpdateOrderInfoViewModel
    {
        public Guid Id { get; set; }
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
        public Status Status { get; set; }
        public Guid ShipmentInfoId { get; set; }
        public Guid UserId { get; set; }
    }
}
