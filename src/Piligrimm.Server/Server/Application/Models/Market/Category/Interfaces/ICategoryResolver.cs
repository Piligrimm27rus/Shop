using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.Server.Application.Models.Market
{
    public interface ICategoryResolver
    {
        IEnumerable<Category> Cast(IEnumerable<CategoryDto> categories);
    }
}