using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.User.Models.BillingAddressViewModels
{
    public class BillingAddressViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public string SubLocation { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }

        public Guid UserId { get; set; }
        public UserViewModel User { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
