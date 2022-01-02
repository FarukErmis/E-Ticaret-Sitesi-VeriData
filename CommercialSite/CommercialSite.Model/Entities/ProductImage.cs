using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class ProductImage : CoreEntity
    {
        public ProductImage()
        {
            ProductDetails = new HashSet<ProductDetail>();
        }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public string ImageUrl { get; set; }

        public User CreatedUserProductImage { get; set; }
        public User UpdatedUserProductImage { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
