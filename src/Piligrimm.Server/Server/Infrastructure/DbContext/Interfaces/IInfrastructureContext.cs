using Microsoft.EntityFrameworkCore;
using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.Server.Infrastructure
{
    public interface IInfrastructureContext
    {
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<ProductEntity> Product { get; set; }
    }
}
