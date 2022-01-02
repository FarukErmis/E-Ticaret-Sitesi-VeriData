using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.User.Models.OrderViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommercialSite.Web.UI.Areas.User.Models.ShipmentInfoViewModels;

namespace CommercialSite.Web.UI.Areas.User.Models.OrderInfoViewModels
{
    public class OrderInfoViewModel
    {
        public OrderInfoViewModel()
        {
            Orders = new HashSet<OrderViewModel>();
        }
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
        public DateTime? CreatedDate { get; set; }
        public Guid ShipmentInfoId { get; set; }
        public ShipmentInfoViewModel ShipmentInfo { get; set; }
        public Guid UserId { get; set; }
        public UserViewModel User { get; set; }
        public ICollection<OrderViewModel> Orders { get; set; }
    }
}
