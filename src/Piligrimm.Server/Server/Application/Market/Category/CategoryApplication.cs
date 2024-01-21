using Piligrimm.Server.Infrastructure.Models.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Application.Market
{
    public class CategoryApplication : ICategoryApplication
    {
        private readonly ICategoryInfrastructure _categoryInfrastructure;
        private readonly ICategoryResolver _categoryResolver;

        public CategoryApplication(
            ICategoryInfrastructure categoryInfrastructure,
            ICategoryResolver categoryResolver)
        {
            _categoryInfrastructure = categoryInfrastructure;
            _categoryResolver = categoryResolver;
        }

        public IEnumerable<Category> GetAll()
        {
            var categories = _categoryInfrastructure.GetAll();
            
            return _categoryResolver.Cast(categories);
        }
    }
}