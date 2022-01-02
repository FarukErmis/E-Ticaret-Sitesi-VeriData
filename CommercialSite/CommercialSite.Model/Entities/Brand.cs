using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class Brand : CoreEntity
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public string BrandName { get; set; }

        public User CreatedUserBrand { get; set; }
        public User UpdatedUserBrand { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
