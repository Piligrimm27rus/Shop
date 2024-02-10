using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;
using Ninject.Infrastructure.Language;

namespace Piligrimm.Server.Infrastructure.Market
{
    internal class ProductRepository : IProductRepository
    {
        private readonly InfrastructureContext _infrastructure;
        private readonly IProductResolver _resolver;

        public ProductRepository(InfrastructureContext infrastructure, IProductResolver resolver)
        {
            _infrastructure = infrastructure;
            _resolver = resolver;
        }

        public IEnumerable<Product> GetAll()
        {
            var products = _infrastructure.Product.ToEnumerable();
            return _resolver.Cast(products);
        }
    }
}
