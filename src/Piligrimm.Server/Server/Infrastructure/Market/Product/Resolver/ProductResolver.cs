using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Infrastructure.Market
{
    internal class ProductResolver : IProductResolver
    {
        public IEnumerable<Product> Cast(IEnumerable<ProductEntity> products)
        {
            return products.Select(entity =>
                new Product()
                {
                    Uid = entity.Uid,
                    CategoryUid = entity.CategoryUid,
                    Name = entity.Name,
                    Price = entity.Price,
                    Discount = entity.Discount,
                    Description = entity.Description,
                }
            );
        }
    }
}