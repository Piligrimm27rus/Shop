using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Infrastructure.Models.Market
{
    internal interface IProductResolver
    {
        IEnumerable<Product> Cast(IEnumerable<ProductEntity> categories);
    }
}