using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class Category : CoreEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string CategoryName { get; set; }
        public string Description { get; set; }

        public User CreatedUserCategory { get; set; }
        public User UpdatedUserCategory { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
