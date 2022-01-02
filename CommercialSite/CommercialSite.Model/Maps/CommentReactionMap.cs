using CommercialSite.Core.Map;
using CommercialSite.Model.Entities;
using CommercialSite.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Maps
{
    public class CommentReactionMap : IEntityBuilder
    {
        //İçerisine model builder alır.
        public void Build(ModelBuilder builder)
        {
            builder.Entity<CommentReaction>(entity =>
            {
                entity.ToTable("CommentReactions");

                entity.HasExtended(); // HasExtended => Göndermiş olduğu entity içerisindeki property'leri kendi içerisinde map'ler. 

                entity
                    .HasOne(c => c.CreatedUserCommentReaction)
                    .WithMany(u => u.CreatedUserCommentReactions)
                    .HasForeignKey(c => c.CreatedUserId);

                entity
                    .HasOne(c => c.UpdatedUserCommentReaction)
                    .WithMany(u => u.UpdatedUserCommentReactions)
                    .HasForeignKey(c => c.UpdatedUserId);

                entity
                    .HasOne(c => c.Comment)
                    .WithMany(u => u.CommentReactions)
                    .HasForeignKey(c => c.ProductCommentId);
            });
        }
    }
}
