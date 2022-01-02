using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class ProductDetailMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<ProductDetail>(entity =>
            {
                entity.ToTable("ProductDetails");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity
                    .HasOne(c => c.CreatedUserProductDetail)
                    .WithMany(u => u.CreatedUserProductDetails)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserProductDetail)
                    .WithMany(u => u.UpdatedUserProductDetails)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.Product)
                    .WithMany(u => u.ProductDetails)
                    .HasForeignKey(c => c.ProductId);

                entity
                   .HasOne(c => c.ProductComment)
                   .WithMany(u => u.ProductDetails)
                   .HasForeignKey(c => c.ProductCommentId);

                entity
                   .HasOne(c => c.ProductProperty)
                   .WithMany(u => u.ProductDetails)
                   .HasForeignKey(c => c.ProductPropertyId);

                entity
                   .HasOne(c => c.ProductImage)
                   .WithMany(u => u.ProductDetails)
                   .HasForeignKey(c => c.ProductImageId);

                entity
                   .HasOne(c => c.ShippingSetting)
                   .WithMany(u => u.ProductDetails)
                   .HasForeignKey(c => c.ShippingSettingId);
            });
        }
    }
}
