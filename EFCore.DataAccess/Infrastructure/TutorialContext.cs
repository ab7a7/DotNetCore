using EFCore.DataAccess.Configurations.Entities;
using EFCore.DataAccess.Configurations.Extensions;
using Microsoft.EntityFrameworkCore;

namespace EFCore.DataAccess.Infrastructure
{
    public class TutorialContext : DbContext
    {
        public TutorialContext(DbContextOptions<TutorialContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new PostConfiguration());
            modelBuilder.AddConfiguration(new CategoryConfiguration());
            modelBuilder.AddConfiguration(new GadgetConfiguration());
        }
    }
}
