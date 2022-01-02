using CommercialSite.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.User.Models.OrderViewModels
{
    public class CreateOrderViewModel
    {
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }

        public Guid OrderInfoId { get; set; }
    }
}
