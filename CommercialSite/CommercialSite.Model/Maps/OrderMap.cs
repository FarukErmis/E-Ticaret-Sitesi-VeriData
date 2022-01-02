using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class OrderMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<Order>(entity =>
            {
                entity.ToTable("Orders");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity
                    .HasOne(c => c.CreatedUserOrder)
                    .WithMany(u => u.CreatedUserOrders)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserOrder)
                    .WithMany(u => u.UpdatedUserOrders)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.Product)
                    .WithMany(u => u.Orders)
                    .HasForeignKey(c => c.ProductId);

                entity
                    .HasOne(c => c.User)
                    .WithMany(u => u.Orders)
                    .HasForeignKey(c => c.UserId);

                entity
                   .HasOne(c => c.OrderInfo)
                   .WithMany(u => u.Orders)
                   .HasForeignKey(c => c.OrderInfoId);
            });
        }
    }
}
