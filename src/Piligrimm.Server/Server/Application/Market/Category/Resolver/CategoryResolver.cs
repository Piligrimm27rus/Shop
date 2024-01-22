using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Application.Market
{
    public class CategoryResolver : ICategoryResolver
    {
        public IEnumerable<Category> Cast(IEnumerable<CategoryDto> categories)
        {
            return categories.Select(categoryDto =>
                new Category()
                {
                    Uid = categoryDto.Uid,
                    Name = categoryDto.Name,
                    Price = categoryDto.Price,
                    Description = categoryDto.Description
                }
            );
        }
    }
}