using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class CategoryMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<Category>(entity =>
            {
                entity.ToTable("Categories");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.CategoryName).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.Description).HasMaxLength(255).IsRequired(false);

                entity
                    .HasOne(c => c.CreatedUserCategory)
                    .WithMany(u => u.CreatedUserCategories)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserCategory)
                    .WithMany(u => u.UpdatedUserCategories)
                    .HasForeignKey(c => c.UpdatedUserId);
            });
        }
    }
}
