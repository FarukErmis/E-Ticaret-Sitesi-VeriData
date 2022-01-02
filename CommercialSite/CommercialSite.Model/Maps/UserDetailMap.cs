using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class UserDetailMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<UserDetail>(entity =>
            {
                entity.ToTable("UserDetails");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity.Property(x => x.TCKN).HasMaxLength(11).IsRequired(false);
                entity.Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired(false);
                entity.Property(x => x.BirthDate).HasMaxLength(11).IsRequired(false);
                entity.Property(x => x.Gender).IsRequired(false);

                entity
                    .HasOne(c => c.CreatedUserDetail)
                    .WithMany(u => u.CreatedUserDetails)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserDetail)
                    .WithMany(u => u.UpdatedUserDetails)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.User)
                    .WithMany(u => u.UserDetails)
                    .HasForeignKey(c => c.UserId);
            });
        }
    }
}
