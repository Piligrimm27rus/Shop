using Piligrimm.Server.Application.Models.Market;
using Microsoft.EntityFrameworkCore;

namespace Piligrimm.Server.Infrastructure
{
    public class InfrastructureContext : DbContext
    {
        internal DbSet<Category> Category { get; set; }
        internal DbSet<Product> Product { get; set; }

        public InfrastructureContext(DbContextOptions<InfrastructureContext> dbContextOptions)
            : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureCategories(modelBuilder);
            ConfigureProducts(modelBuilder);
        }

        private void ConfigureCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Category>().HasKey(c => c.Uid);
        }

        private void ConfigureProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasKey(c => c.Uid);
        }
    }
}