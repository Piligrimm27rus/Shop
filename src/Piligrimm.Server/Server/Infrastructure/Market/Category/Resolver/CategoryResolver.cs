using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Infrastructure.Market
{
    internal class CategoryResolver : ICategoryResolver
    {
        public IEnumerable<Category> Cast(IEnumerable<CategoryEntity> categories)
        {
            return categories.Select(entity =>
                new Category()
                {
                    Uid = entity.Uid,
                    ParentId = entity.ParentId,
                    Name = entity.Name,
                    Description = entity.Description
                }
            );
        }
    }
}