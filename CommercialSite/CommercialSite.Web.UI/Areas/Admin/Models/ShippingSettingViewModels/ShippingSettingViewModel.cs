using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductDetailViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ShippingSettingViewModels
{
    public class ShippingSettingViewModel
    {
        public ShippingSettingViewModel()
        {
            ProductDetails = new HashSet<ProductDetailViewModel>();
        }
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public ProductViewModel Product { get; set; }
        [Required]
        public bool IsShippingFree { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<ProductDetailViewModel> ProductDetails { get; set; }
    }
}
