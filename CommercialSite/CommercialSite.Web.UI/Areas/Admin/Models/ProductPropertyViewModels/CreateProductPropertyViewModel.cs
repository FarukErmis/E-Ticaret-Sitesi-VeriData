using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ProductPropertyViewModels
{
    public class CreateProductPropertyViewModel
    {
        public Guid ProductId { get; set; }
        [Required]
        public string VarKey { get; set; }
        [Required]
        public string VarValue { get; set; }
        public Status Status { get; set; }
    }
}
