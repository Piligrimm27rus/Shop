using Piligrimm.Server.Application.Models.Market;
using Ninject.Infrastructure.Language;

namespace Piligrimm.Server.Infrastructure.Market
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly InfrastructureContext _infrastructure;
        private readonly ICategoryResolver _resolver;

        public CategoryRepository(InfrastructureContext infrastructure, ICategoryResolver resolver)
        {
            _infrastructure = infrastructure;
            _resolver = resolver;
        }

        public IEnumerable<Category> GetAll()
        {
            var categories = _infrastructure.Category.ToEnumerable();
            return _resolver.Cast(categories);
        }
    }
}