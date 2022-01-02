using CommercialSite.Core.Entity;
using System;

namespace CommercialSite.Model.Entities
{
    public class CommentReaction : CoreEntity
    {
        public Guid ProductCommentId { get; set; }
        public ProductComment Comment { get; set; }

        public User CreatedUserCommentReaction { get; set; }
        public User UpdatedUserCommentReaction { get; set; }
    }
}
