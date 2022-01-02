using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class ProductCommentMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<ProductComment>(entity =>
            {
                entity.ToTable("ProductComments");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.Comment).HasMaxLength(1024).IsRequired(true);
                entity.Property(x => x.Rate).IsRequired(true);
                entity.Property(x => x.ThumbsUp).IsRequired(false);
                entity.Property(x => x.ThumbDown).IsRequired(false);

                entity
                    .HasOne(c => c.CreatedUserProductComment)
                    .WithMany(u => u.CreatedUserProductComments)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserProductComment)
                    .WithMany(u => u.UpdatedUserProductComments)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.Product)
                    .WithMany(u => u.ProductComments)
                    .HasForeignKey(c => c.ProductId);
            });
        }
    }
}
