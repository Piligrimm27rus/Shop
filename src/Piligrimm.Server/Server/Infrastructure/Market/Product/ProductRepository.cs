using Piligrimm.Server.Application.Models.Market;
using Ninject.Infrastructure.Language;

namespace Piligrimm.Server.Infrastructure.Market
{
    internal class ProductRepository : IProductRepository
    {
        private readonly InfrastructureContext _infrastructure;

        public ProductRepository(InfrastructureContext infrastructure)
        {
            _infrastructure = infrastructure;
        }

        public Task<IEnumerable<Product>> GetAll(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                cancellationToken.ThrowIfCancellationRequested();
            }

            return Task.FromResult(_infrastructure.Product.ToEnumerable());
        }
    }
}
