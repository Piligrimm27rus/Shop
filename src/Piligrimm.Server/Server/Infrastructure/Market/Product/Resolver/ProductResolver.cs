using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Infrastructure.Market
{
    internal class ProductResolver : IProductResolver
    {
        private readonly ICategoryResolver _categoryResolver;
        internal ProductResolver(ICategoryResolver categoryResolver)
        {
            _categoryResolver = categoryResolver;
        }

        public IEnumerable<Product> Cast(IEnumerable<ProductEntity> products)
        {
            return products.Select(entity =>
                new Product()
                {
                    Uid = entity.Uid,
                    Category = _categoryResolver.Cast(entity.Category),
                    Name = entity.Name,
                    Price = entity.Price,
                    Discount = entity.Discount,
                    Description = entity.Description,
                }
            );
        }
    }
}