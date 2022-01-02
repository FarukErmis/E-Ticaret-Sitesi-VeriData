using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class ShipmentInfoMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<ShipmentInfo>(entity =>
            {
                entity.ToTable("ShipmentInfos");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.ShipmentName).HasMaxLength(50).IsRequired(true);

                entity
                    .HasOne(c => c.CreatedUserShipmentInfo)
                    .WithMany(u => u.CreatedUserShipmentInfos)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserShipmentInfo)
                    .WithMany(u => u.UpdatedUserShipmentInfos)
                    .HasForeignKey(c => c.UpdatedUserId);
            });
        }
    }
}
