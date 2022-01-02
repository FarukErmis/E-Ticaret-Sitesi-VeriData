using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.User.Models.OrderInfoViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.User.Models.OrderViewModels
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid ProductId { get; set; }
        public ProductViewModel Product { get; set; }

        public Guid UserId { get; set; }
        public UserViewModel User { get; set; }

        public Guid OrderInfoId { get; set; }
        public OrderInfoViewModel OrderInfo { get; set; }
        
    }
}
