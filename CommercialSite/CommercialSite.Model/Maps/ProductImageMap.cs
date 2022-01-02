using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class ProductImageMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("ProductImages");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.ImageUrl).HasMaxLength(50).IsRequired(true);

                entity
                    .HasOne(c => c.CreatedUserProductImage)
                    .WithMany(u => u.CreatedUserProductImages)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserProductImage)
                    .WithMany(u => u.UpdatedUserProductImages)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.Product)
                    .WithMany(u => u.ProductImages)
                    .HasForeignKey(c => c.ProductId);
            });
        }
    }
}
