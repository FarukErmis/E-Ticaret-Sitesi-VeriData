using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.User.Models.OrderInfoViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.User.Models.ShipmentInfoViewModels
{
    public class ShipmentInfoViewModel
    {
        public ShipmentInfoViewModel()
        {
            OrderInfos = new HashSet<OrderInfoViewModel>();
        }
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ShipmentName { get; set; }
        public ICollection<OrderInfoViewModel> OrderInfos { get; set; }
    }
}
