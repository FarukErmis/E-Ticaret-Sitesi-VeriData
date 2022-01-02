using CommercialSite.Core.Entity.Enums;
using CommercialSite.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.SeedData
{
    public class UserSeedData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = Guid.NewGuid(),
                    Status = Status.Active,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@admin.com",
                    Password = "123",
                    Title = "admin",
                    AvatarUrl = "/",
                    LastLogin = DateTime.Now,
                    LastIPAddress = "127.0.0.1"
                });
        }
    }
}
