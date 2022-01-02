using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ShippingSettingViewModels
{
    public class CreateShippingSettingViewModel
    {
        public Guid ProductId { get; set; }
        [Required]
        public bool IsShippingFree { get; set; }
        public Status Status { get; set; }
    }
}
