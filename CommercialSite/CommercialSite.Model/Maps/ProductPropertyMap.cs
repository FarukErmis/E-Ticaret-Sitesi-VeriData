using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class ProductPropertyMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<ProductProperty>(entity =>
            {
                entity.ToTable("ProductProperties");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.VarKey).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.VarValue).HasMaxLength(50).IsRequired(true);

                entity
                    .HasOne(c => c.CreatedUserProductProperty)
                    .WithMany(u => u.CreatedUserProductProperties)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserProductProperty)
                    .WithMany(u => u.UpdatedUserProductProperties)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.Product)
                    .WithMany(u => u.ProductProperties)
                    .HasForeignKey(c => c.ProductId);
            });
        }
    }
}
