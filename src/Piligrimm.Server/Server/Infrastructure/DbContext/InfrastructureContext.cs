using Piligrimm.Server.Infrastructure.Models.Market;
using Microsoft.EntityFrameworkCore;

namespace Piligrimm.Server.Infrastructure
{
    public class InfrastructureContext : DbContext
    {
        internal DbSet<CategoryEntity> Category { get; set; }
        internal DbSet<ProductEntity> Product { get; set; }

        public InfrastructureContext(DbContextOptions<InfrastructureContext> dbContextOptions)
            : base(dbContextOptions) { }
    }
}