using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.BrandViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.CategoryViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductCommentViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductDetailViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductImageViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductPropertyViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ShippingSettingViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            ProductImages = new HashSet<ProductImageViewModel>();
            ProductProperties = new HashSet<ProductPropertyViewModel>();
            ShippingSettings = new HashSet<ShippingSettingViewModel>();
            ProductDetails = new HashSet<ProductDetailViewModel>();
            ProductComments = new HashSet<ProductCommentViewModel>();
        }
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }

        public Guid BrandId { get; set; }
        public BrandViewModel Brand { get; set; }
        public Status Status { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Required]
        public double WithoutDiscountPrice { get; set; }
        public double? DiscountPrice { get; set; }
        public int? Rate { get; set; }
        public int? ReviewNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<ProductImageViewModel> ProductImages { get; set; }
        public ICollection<ProductCommentViewModel> ProductComments { get; set; }
        public ICollection<ProductPropertyViewModel> ProductProperties { get; set; }
        public ICollection<ShippingSettingViewModel> ShippingSettings { get; set; }
        public ICollection<ProductDetailViewModel> ProductDetails { get; set; }
    }
}
