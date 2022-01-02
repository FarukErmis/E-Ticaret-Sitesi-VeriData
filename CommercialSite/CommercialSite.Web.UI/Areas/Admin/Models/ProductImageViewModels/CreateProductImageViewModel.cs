using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ProductImageViewModels
{
    public class CreateProductImageViewModel
    {
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; }
        public Status Status { get; set; }
    }
}
