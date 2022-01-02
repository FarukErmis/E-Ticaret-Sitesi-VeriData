using CommercialSite.Core.Entity.Enums;
using CommercialSite.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.SeedData
{
    public class ShipmentInfoSeedData : IEntityTypeConfiguration<ShipmentInfo>
    {
        public void Configure(EntityTypeBuilder<ShipmentInfo> builder)
        {
            builder.HasData(
                new ShipmentInfo
                {
                    Id = Guid.NewGuid(),
                    Status = Status.Active,
                    ShipmentName = "JetTekno"
                });
        }
    }
}
