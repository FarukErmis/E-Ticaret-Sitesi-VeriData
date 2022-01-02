using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.BillingAddress
{
    public class BillingAddressRequest : BaseDto
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public string SubLocation { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Guid UserId { get; set; }
    }
}
