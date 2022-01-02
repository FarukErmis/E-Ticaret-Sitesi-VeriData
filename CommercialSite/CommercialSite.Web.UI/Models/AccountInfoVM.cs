using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Models
{
    public class AccountInfoVM
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public Guid BillingId { get; set; }
        public string BillingFirstName { get; set; }
        public string BillingSurName { get; set; }
        public string BillingCountry { get; set; }
        public string BillingLocation { get; set; }
        public string BillingSubLocation { get; set; }
        public string BillingAdress { get; set; }
        public string BillingPhoneNumber { get; set; }
        public string BillingEmail { get; set; }
        public Guid ShippingId { get; set; }
        public string ShippingFirstName { get; set; }
        public string ShippingSurName { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingLocation { get; set; }
        public string ShippingSubLocation { get; set; }
        public string ShippingAdress { get; set; }
        public string ShippingPhoneNumber { get; set; }
        public string ShippingEmail { get; set; }

    }
}
