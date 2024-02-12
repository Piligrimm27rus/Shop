using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Infrastructure.Market
{
    internal static class ProductResolverExtention
    {
        public static IEnumerable<Product> Cast(this IEnumerable<ProductEntity> products)
        {
            return products.Select(entity =>
                new Product()
                {
                    Uid = entity.Uid,
                    Category = entity.Category.Cast(),
                    Name = entity.Name,
                    Price = entity.Price,
                    Discount = entity.Discount,
                    Description = entity.Description,
                }
            );
        }
    }
}