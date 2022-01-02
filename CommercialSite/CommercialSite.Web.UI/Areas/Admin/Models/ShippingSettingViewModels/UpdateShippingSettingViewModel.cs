using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ShippingSettingViewModels
{
    public class UpdateShippingSettingViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        [Required]
        public bool IsShippingFree { get; set; }
        public Status Status { get; set; }
    }
}
