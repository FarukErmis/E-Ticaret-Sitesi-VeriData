using CommercialSite.Core.Entity.Enums;
using CommercialSite.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.SeedData
{
    public class BrandSeedData : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand
                {
                    Id = Guid.NewGuid(),
                    BrandName = "ACER",
                    Status = Status.Active
                });
            builder.HasData(
                new Brand
                {
                    Id = Guid.NewGuid(),
                    BrandName = "Lenovo",
                    Status = Status.Active
                });
            builder.HasData(
                new Brand
                {
                    Id = Guid.NewGuid(),
                    BrandName = "Samsung",
                    Status = Status.Active
                });
            builder.HasData(
                new Brand
                {
                    Id = Guid.NewGuid(),
                    BrandName = "Apple",
                    Status = Status.Active
                });
            builder.HasData(
                new Brand
                {
                    Id = Guid.NewGuid(),
                    BrandName = "Xiaomi",
                    Status = Status.Active
                });
            builder.HasData(
                new Brand
                {
                    Id = Guid.NewGuid(),
                    BrandName = "Oppo",
                    Status = Status.Active
                });
            builder.HasData(
                new Brand
                {
                    Id = Guid.NewGuid(),
                    BrandName = "Philips",
                    Status = Status.Active
                });
            builder.HasData(
                new Brand
                {
                    Id = Guid.NewGuid(),
                    BrandName = "LG",
                    Status = Status.Active
                });
            builder.HasData(
                new Brand
                {
                    Id = Guid.NewGuid(),
                    BrandName = "Reeder",
                    Status = Status.Active
                });
        }
    }
}
