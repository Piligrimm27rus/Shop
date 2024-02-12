using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Infrastructure.Market
{
    internal static class CategoryResolverExtention
    {
        public static IEnumerable<Category> Cast(this IEnumerable<CategoryEntity> categories)
        {
            return categories.Select(Cast);
        }

        public static Category Cast(this CategoryEntity category)
        {
            return new Category()
            {
                Uid = category.Uid,
                ParentId = category.ParentId,
                Name = category.Name,
                Description = category.Description
            };
        }
    }
}