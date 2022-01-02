using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.BrandViewModels
{
    public class UpdateBrandViewModel
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        [Required]
        public string BrandName { get; set; }
    }
}
