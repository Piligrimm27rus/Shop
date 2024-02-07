using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.Server.Application.Models.Market
{
    public interface IProductResolver
    {
        IEnumerable<Product> Cast(IEnumerable<ProductEntity> categories);
    }
}