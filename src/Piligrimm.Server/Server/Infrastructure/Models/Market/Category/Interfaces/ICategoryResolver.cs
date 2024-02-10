using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.Server.Application.Models.Market
{
    internal interface ICategoryResolver
    {
        internal IEnumerable<Category> Cast(IEnumerable<CategoryEntity> categories);
    }
}