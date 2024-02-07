using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Application.Market
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductInfrastructure _productInfrastructure;
        private readonly IProductResolver _productResolver;

        public ProductApplication(
            IProductInfrastructure productInfrastructure,
            IProductResolver productResolver)
        {
            _productInfrastructure = productInfrastructure;
            _productResolver = productResolver;
        }

        public IEnumerable<Product> GetAll()
        {
            var categories = _productInfrastructure.GetAll();
            
            return _productResolver.Cast(categories);
        }
    }
}