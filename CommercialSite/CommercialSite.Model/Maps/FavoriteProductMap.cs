using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class FavoriteProductMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<FavoriteProduct>(entity =>
            {
                entity.ToTable("FavoriteProducts");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity
                    .HasOne(c => c.CreatedUserFavoriteProduct)
                    .WithMany(u => u.CreatedUserFavoriteProducts)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserFavoriteProduct)
                    .WithMany(u => u.UpdatedUserFavoriteProducts)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.Product)
                    .WithMany(u => u.FavoriteProducts)
                    .HasForeignKey(c => c.ProductId);

                entity
                    .HasOne(c => c.User)
                    .WithMany(u => u.FavoriteProducts)
                    .HasForeignKey(c => c.UserId);
            });
        }
    }
}
