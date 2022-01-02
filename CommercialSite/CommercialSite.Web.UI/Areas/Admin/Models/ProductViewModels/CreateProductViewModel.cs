using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels
{
    public class CreateProductViewModel
    {
        public Guid CategoryId { get; set; }

        public Guid BrandId { get; set; }
        public Status Status { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Required]
        public double WithoutDiscountPrice { get; set; }
        public double? DiscountPrice { get; set; }
        public int? Rate { get; set; }
        public int? ReviewNumber { get; set; }
    }
}
