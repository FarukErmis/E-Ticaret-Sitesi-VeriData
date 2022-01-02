using CommercialSite.Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps.Base
{

    //Burada core entity içerisindeki tüm tablolarda geçerli olan property'leri mapliyoruz. Bu şekilde aynı şeyi birden fazla yazmayı önlemiş oluruz. 
    public static class EntityBuilderExtension
    {
        public static void HasExtended<T>(this EntityTypeBuilder<T> entity) where T : CoreEntity
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd(); // ValueGeneratedOnAdd => Guidlerin içerisine yeni data gönderirken, GuidId göndermeye gerek kalmadan oto increment olarak oluşur.
            entity.Property(x => x.Status).IsRequired(true);

            entity.Property(x => x.CreatedDate).IsRequired(false);
            entity.Property(x => x.CreatedIp).HasMaxLength(15).IsRequired(false);
            entity.Property(x => x.CreatedUserId).IsRequired(false);

            entity.Property(x => x.UpdatedDate).IsRequired(false);
            entity.Property(x => x.UpdatedIp).HasMaxLength(15).IsRequired(false);
            entity.Property(x => x.UpdatedUserId).IsRequired(false);
        }
    }
}
