using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class ShippingAddress : CoreEntity
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
        public User User { get; set; }

        public User CreatedUserShippingAddress { get; set; }
        public User UpdatedUserShippingAddress { get; set; }
    }
}
