using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductCommentViewModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.CommentReactionViewModels
{
    public class CreateCommentReactionViewModel
    {
        public Status Status { get; set; }
        public Guid ProductCommentId { get; set; }
    }
}
