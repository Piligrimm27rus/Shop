using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.Server.Application.Models.Market
{
    internal interface ICategoryResolver
    {
        IEnumerable<Category> Cast(IEnumerable<CategoryEntity> categories);
        Category Cast(CategoryEntity category);
    }
}