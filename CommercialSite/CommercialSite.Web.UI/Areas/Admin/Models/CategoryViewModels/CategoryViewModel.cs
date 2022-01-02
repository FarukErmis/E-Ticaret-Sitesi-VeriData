using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.CategoryViewModels
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Products = new HashSet<ProductViewModel>();
        }
        public Guid Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
    }
}
