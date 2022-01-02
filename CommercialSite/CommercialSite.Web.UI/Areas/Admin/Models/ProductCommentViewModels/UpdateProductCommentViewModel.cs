using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ProductCommentViewModels
{
    public class UpdateProductCommentViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        public string Comment { get; set; }
        [Required]
        public string Rate { get; set; }
        public int? ThumbsUp { get; set; }
        public int? ThumbDown { get; set; }
        public Status Status { get; set; }
    }
}
