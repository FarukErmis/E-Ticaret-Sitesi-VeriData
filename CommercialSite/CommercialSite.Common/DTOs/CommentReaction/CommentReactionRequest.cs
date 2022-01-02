using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.CommentReaction
{
    public class CommentReactionRequest : BaseDto
    {
        public Guid ProductCommentId { get; set; }
    }
}
