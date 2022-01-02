using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductDetailViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ProductPropertyViewModels
{
    public class ProductPropertyViewModel
    {
        public ProductPropertyViewModel()
        {
            ProductDetails = new HashSet<ProductDetailViewModel>();
        }
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public ProductViewModel Product { get; set; }
        [Required]
        public string VarKey { get; set; }
        [Required]
        public string VarValue { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<ProductDetailViewModel> ProductDetails { get; set; }
    }
}
