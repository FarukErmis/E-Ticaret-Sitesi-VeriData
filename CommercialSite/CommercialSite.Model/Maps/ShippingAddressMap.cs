using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class ShippingAddressMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<ShippingAddress>(entity =>
            {
                entity.ToTable("ShippingAddresses");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.FirstName).HasMaxLength(100).IsRequired(true);
                entity.Property(x => x.SurName).HasMaxLength(100).IsRequired(true);
                entity.Property(x => x.Country).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.Location).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.SubLocation).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.Adress).HasMaxLength(255).IsRequired(true);
                entity.Property(x => x.PhoneNumber).HasMaxLength(15).IsRequired(true);
                entity.Property(x => x.Email).IsRequired(true);

                entity
                    .HasOne(c => c.CreatedUserShippingAddress)
                    .WithMany(u => u.CreatedUserShippingAddresses)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserShippingAddress)
                    .WithMany(u => u.UpdatedUserShippingAddresses)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.User)
                    .WithMany(u => u.ShippingAddresses)
                    .HasForeignKey(c => c.UserId);
            });
        }
    }
}
