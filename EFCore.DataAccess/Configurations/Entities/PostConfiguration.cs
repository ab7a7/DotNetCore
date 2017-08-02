using EFCore.DataAccess.Configurations.Extensions;
using EFCore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.DataAccess.Configurations.Entities
{
    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public override void Map(EntityTypeBuilder<Post> builder)
        {
            builder.HasOne(d => d.Blog)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.BlogId);
        }
    }
}
