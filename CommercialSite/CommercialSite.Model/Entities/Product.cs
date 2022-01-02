using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class Product : CoreEntity
    {
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
            ProductProperties = new HashSet<ProductProperty>();
            ShippingSettings = new HashSet<ShippingSetting>();
            ProductDetails = new HashSet<ProductDetail>();
            ProductComments = new HashSet<ProductComment>();
            FavoriteProducts = new HashSet<FavoriteProduct>();
            Orders = new HashSet<Order>();
        }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public double WithoutDiscountPrice { get; set; }
        public double? DiscountPrice { get; set; }
        public int? Rate { get; set; }
        public int? ReviewNumber { get; set; }

        public User CreatedUserProduct { get; set; }
        public User UpdatedUserProduct { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }
        public ICollection<ProductProperty> ProductProperties { get; set; }
        public ICollection<ShippingSetting> ShippingSettings { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ICollection<FavoriteProduct> FavoriteProducts { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
