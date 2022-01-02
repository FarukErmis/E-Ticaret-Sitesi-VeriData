using CommercialSite.Core.Entity.Enums;
using CommercialSite.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.SeedData
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Bilgisayar",
                    Status = Status.Active
                });
            builder.HasData(
                new Category
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Telefon",
                    Status = Status.Active
                });
            builder.HasData(
                new Category
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Tablet",
                    Status = Status.Active
                });
            builder.HasData(
                new Category
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Televizyon",
                    Status = Status.Active
                });
        }
    }
}
