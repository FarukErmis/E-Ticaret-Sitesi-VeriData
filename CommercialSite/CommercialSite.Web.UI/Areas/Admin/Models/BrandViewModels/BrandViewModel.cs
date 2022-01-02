using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.BrandViewModels
{
    public class BrandViewModel
    {
        public BrandViewModel()
        {
            Products = new HashSet<ProductViewModel>();
        }
        public Guid Id { get; set; }
        public Status Status { get; set; }
        [Required]
        public string BrandName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
    }
}
