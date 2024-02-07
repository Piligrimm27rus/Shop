using Piligrimm.Server.Infrastructure.Models.Market;
using Ninject.Infrastructure.Language;

namespace Piligrimm.Server.Infrastructure.Market
{
    public class ProductInfrastructure : IProductInfrastructure
    {
        private readonly IInfrastructureContext _infrastructure;

        public ProductInfrastructure(IInfrastructureContext infrastructure)
        {
            _infrastructure = infrastructure;
        }

        public IEnumerable<ProductEntity> GetAll()
        {
            return _infrastructure.Product.ToEnumerable();
        }
    }
}
