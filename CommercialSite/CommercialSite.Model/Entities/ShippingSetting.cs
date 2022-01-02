using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class ShippingSetting : CoreEntity
    {
        public ShippingSetting()
        {
            ProductDetails = new HashSet<ProductDetail>();
        }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public bool IsShippingFree { get; set; }

        public User CreatedUserShippingSetting { get; set; }
        public User UpdatedUserShippingSetting { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
