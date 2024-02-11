using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Infrastructure.Market
{
    internal class CategoryResolver : ICategoryResolver
    {
        public IEnumerable<Category> Cast(IEnumerable<CategoryEntity> categories)
        {
            return categories.Select(Cast);
        }

        public Category Cast(CategoryEntity category)
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