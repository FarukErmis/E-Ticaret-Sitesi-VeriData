using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.CommentReactionViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductDetailViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.ProductCommentViewModels
{
    public class ProductCommentViewModel
    {
        public ProductCommentViewModel()
        {
            ProductDetails = new HashSet<ProductDetailViewModel>();
            CommentReactions = new HashSet<CommentReactionViewModel>();
        }
        public Guid Id { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        public ProductViewModel Product { get; set; }
        public string Comment { get; set; }
        [Required]
        public string Rate { get; set; }
        public int? ThumbsUp { get; set; }
        public int? ThumbDown { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<ProductDetailViewModel> ProductDetails { get; set; }
        public ICollection<CommentReactionViewModel> CommentReactions { get; set; }
    }
}
