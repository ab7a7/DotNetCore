using EFCore.DataAccess.Configurations.Extensions;
using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.DataAccess.Configurations.Entities
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public override void Map(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).IsRequired();
        }
    }
}
