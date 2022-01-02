using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class OrderInfoMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<OrderInfo>(entity =>
            {
                entity.ToTable("OrderInfos");

                entity.Property(x => x.ShippingFirstName).HasMaxLength(100).IsRequired(true);
                entity.Property(x => x.ShippingSurname).HasMaxLength(100).IsRequired(true);
                entity.Property(x => x.ShippingCountry).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.ShippingLocation).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.ShippingSubLocation).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.ShippingAddress).HasMaxLength(255).IsRequired(true);
                entity.Property(x => x.ShippingPhoneNumber).HasMaxLength(15).IsRequired(true);
                entity.Property(x => x.ShippingEmail).IsRequired(true);

                entity.Property(x => x.BillingFirstName).HasMaxLength(100).IsRequired(true);
                entity.Property(x => x.BillingSurname).HasMaxLength(100).IsRequired(true);
                entity.Property(x => x.BillingCountry).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.BillingLocation).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.BillingSubLocation).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.BillingAddress).HasMaxLength(255).IsRequired(true);
                entity.Property(x => x.BillingPhoneNumber).HasMaxLength(15).IsRequired(true);
                entity.Property(x => x.BillingEmail).IsRequired(true);

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity
                    .HasOne(c => c.CreatedUserOrderInfo)
                    .WithMany(u => u.CreatedUserOrderInfos)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserOrderInfo)
                    .WithMany(u => u.UpdatedUserOrderInfos)
                    .HasForeignKey(c => c.UpdatedUserId);
                entity
                   .HasOne(c => c.ShipmentInfo)
                   .WithMany(u => u.OrderInfos)
                   .HasForeignKey(c => c.ShipmentInfoId);

                entity
                    .HasOne(c => c.User)
                    .WithMany(u => u.OrderInfos)
                    .HasForeignKey(c => c.UserId);
            });
        }
    }
}
