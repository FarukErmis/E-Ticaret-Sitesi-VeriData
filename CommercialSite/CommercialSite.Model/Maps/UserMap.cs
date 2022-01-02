using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class UserMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.FirstName).HasMaxLength(30).IsRequired(true);
                entity.Property(x => x.LastName).HasMaxLength(15).IsRequired(true);
                entity.Property(x => x.Title).HasMaxLength(20).IsRequired(false);
                entity.Property(x => x.AvatarUrl).HasMaxLength(255).IsRequired(false);
                entity.Property(x => x.Email).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.Password).HasMaxLength(12).IsRequired(true);
                entity.Property(x => x.LastLogin).IsRequired(false);
                entity.Property(x => x.LastIPAddress).HasMaxLength(15).IsRequired(false);

                entity
                    .HasOne(c => c.CreatedUser)
                    .WithMany(u => u.CreatedUsers)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUser)
                    .WithMany(u => u.UpdatedUsers)
                    .HasForeignKey(c => c.UpdatedUserId);
            });
        }
    }
}
