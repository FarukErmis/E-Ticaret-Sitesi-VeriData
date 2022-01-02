using CommercialSite.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.BrandViewModels
{
    public class CreateBrandViewModel
    {
        public Status Status { get; set; }
        [Required]
        public string BrandName { get; set; }
    }
}
