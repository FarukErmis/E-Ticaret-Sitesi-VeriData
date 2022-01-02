using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.CategoryViewModels
{
    public class UpdateCategoryViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
