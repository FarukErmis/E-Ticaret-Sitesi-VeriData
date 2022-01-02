using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class BrandMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brands");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.BrandName).HasMaxLength(50).IsRequired(true);

                entity
                    .HasOne(c => c.CreatedUserBrand)
                    .WithMany(u => u.CreatedUserBrands)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserBrand)
                    .WithMany(u => u.UpdatedUserBrands)
                    .HasForeignKey(c => c.UpdatedUserId);
            });
        }
    }
}
