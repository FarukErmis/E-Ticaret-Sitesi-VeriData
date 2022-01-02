using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class ShippingSettingMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<ShippingSetting>(entity =>
            {
                entity.ToTable("ShippingSettings");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.IsShippingFree).IsRequired(true);

                entity
                    .HasOne(c => c.CreatedUserShippingSetting)
                    .WithMany(u => u.CreatedUserShippingSettings)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserShippingSetting)
                    .WithMany(u => u.UpdatedUserShippingSettings)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.Product)
                    .WithMany(u => u.ShippingSettings)
                    .HasForeignKey(c => c.ProductId);
            });
        }
    }
}
