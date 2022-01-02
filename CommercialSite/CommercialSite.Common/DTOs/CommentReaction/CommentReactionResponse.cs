using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.DTOs.ProductComment;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.CommentReaction
{
    public class CommentReactionResponse : BaseDto
    {
        public Guid ProductCommentId { get; set; }
        public ProductCommentResponse ProductComment { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
