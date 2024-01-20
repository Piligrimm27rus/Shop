using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Application.Market
{
    public class CategoryApplication : ICategoryApplication
    {
        private readonly ICategoryInfrastructure _categoryInfrastructure;

        public CategoryApplication(ICategoryInfrastructure categoryInfrastructure)
        {
            _categoryInfrastructure = categoryInfrastructure;
        }

        public IEnumerable<Category> GetAll()
        {
            var categories = _categoryInfrastructure.GetAll();
            
            return CategoryResolver.Cast(categories);
        }
    }
}