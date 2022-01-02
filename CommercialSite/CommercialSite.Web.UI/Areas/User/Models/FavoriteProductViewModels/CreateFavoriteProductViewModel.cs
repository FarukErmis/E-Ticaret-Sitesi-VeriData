using CommercialSite.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.User.Models.FavoriteProductViewModels
{
    public class CreateFavoriteProductViewModel
    {
        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }
        public Status Status { get; set; }
    }
}
