using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;
namespace CommercialSite.Web.UI.Areas.Admin.Models.ProductImageViewModels
{
    public class UpdateProductImageViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public Status Status { get; set; }
    }
}
