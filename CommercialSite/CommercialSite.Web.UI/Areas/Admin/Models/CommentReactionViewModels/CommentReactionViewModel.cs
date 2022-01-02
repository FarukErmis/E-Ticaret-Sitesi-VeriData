using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductCommentViewModels;
using System;

namespace CommercialSite.Web.UI.Areas.Admin.Models.CommentReactionViewModels
{
    public class CommentReactionViewModel
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public Guid ProductCommentId { get; set; }
        public ProductCommentViewModel ProductComments { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
