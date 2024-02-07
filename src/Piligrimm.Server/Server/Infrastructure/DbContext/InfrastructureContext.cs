using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Infrastructure.Extension;
using Microsoft.EntityFrameworkCore;

namespace Piligrimm.Server.Infrastructure
{
    public class InfrastructureContext : DbContext, IInfrastructureContext
    {
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<ProductEntity> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=password;Database=PiligrimmDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.LowercaseRelationalPropertyNames();

            modelBuilder.Entity<CategoryEntity>(m => { m.ToTable("categories"); });
            modelBuilder.Entity<ProductEntity>(m => { m.ToTable("products"); });
        }
    }
}