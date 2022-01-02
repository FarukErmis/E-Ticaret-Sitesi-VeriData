using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.ProductComment
{
    public class ProductCommentRequest : BaseDto
    {
        public Guid ProductId { get; set; }
        public string Comment { get; set; }
        public string Rate { get; set; }
        public int? ThumbsUp { get; set; }
        public int? ThumbDown { get; set; }
    }
}
