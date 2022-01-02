using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class ProductMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<Product>(entity =>
            {
                entity.ToTable("Products");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.ProductName).HasMaxLength(100).IsRequired(true);
                entity.Property(x => x.Description).HasMaxLength(255).IsRequired(false);
                entity.Property(x => x.WithoutDiscountPrice).IsRequired(true);
                entity.Property(x => x.DiscountPrice).IsRequired(false);
                entity.Property(x => x.Rate).IsRequired(false);
                entity.Property(x => x.ReviewNumber).IsRequired(false);

                entity
                    .HasOne(c => c.CreatedUserProduct)
                    .WithMany(u => u.CreatedUserProducts)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserProduct)
                    .WithMany(u => u.UpdatedUserProducts)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.Category)
                    .WithMany(u => u.Products)
                    .HasForeignKey(c => c.CategoryId);

                entity
                    .HasOne(c => c.Brand)
                    .WithMany(u => u.Products)
                    .HasForeignKey(c => c.BrandId);
            });
        }
    }
}
