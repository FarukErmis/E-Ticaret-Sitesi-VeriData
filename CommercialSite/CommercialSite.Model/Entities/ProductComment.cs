using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class ProductComment : CoreEntity
    {
        public ProductComment()
        {
            ProductDetails = new HashSet<ProductDetail>();
            CommentReactions = new HashSet<CommentReaction>();
        }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public string Comment { get; set; }
        public string Rate { get; set; }
        public int? ThumbsUp { get; set; }
        public int? ThumbDown { get; set; }

        public User CreatedUserProductComment { get; set; }
        public User UpdatedUserProductComment { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ICollection<CommentReaction> CommentReactions { get; set; }

    }
}
