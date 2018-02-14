using EFCore.DataAccess.Configurations.Extensions;
using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.DataAccess.Configurations.Entities
{
    public class GadgetConfiguration : EntityTypeConfiguration<Gadget>
    {
        public override void Map(EntityTypeBuilder<Gadget> builder)
        {
            builder.Property(g => g.Name).IsRequired().HasMaxLength(50);
            builder.Property(g => g.Price).IsRequired().HasPrecision(8, 2);
            builder.Property(g => g.Description).IsRequired();
            builder.HasOne(g => g.Category).WithMany(c => c.Gadgets).HasForeignKey(g => g.CategoryId);
        }
    }
}
