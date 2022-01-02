using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class ProductProperty : CoreEntity
    {
        public ProductProperty()
        {
            ProductDetails = new HashSet<ProductDetail>();
        }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public string VarKey { get; set; }
        public string VarValue { get; set; }

        public User CreatedUserProductProperty { get; set; }
        public User UpdatedUserProductProperty { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
