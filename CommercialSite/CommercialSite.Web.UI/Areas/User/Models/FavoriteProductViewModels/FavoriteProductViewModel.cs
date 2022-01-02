using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.User.Models.FavoriteProductViewModels
{
    public class FavoriteProductViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public ProductViewModel Product { get; set; }

        public Guid UserId { get; set; }
        public UserViewModel User { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
