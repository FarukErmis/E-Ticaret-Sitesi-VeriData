using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.FavoriteProduct
{
    public class FavoriteProductRequest : BaseDto
    {
        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }
    }
}
