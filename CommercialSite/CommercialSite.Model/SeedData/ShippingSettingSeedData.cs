using CommercialSite.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.SeedData
{
    public class ShippingSettingSeedData : IEntityTypeConfiguration<ShippingSetting>
    {
        public void Configure(EntityTypeBuilder<ShippingSetting> builder)
        {
            builder.HasData(
               new ShippingSetting
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Core.Entity.Enums.Status.Active,
                   IsShippingFree = true
               });
        }
    }
}
