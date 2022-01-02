using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ProductDetailViewModels
{
    public class CreateProductDetailViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductCommentId { get; set; }
        public Guid ProductPropertyId { get; set; }
        public Guid ProductImageId { get; set; }
        public Guid ShippingSettingId { get; set; }
        public Status Status { get; set; }
    }
}
