using Piligrimm.Server.Infrastructure.Models.Market;
using Ninject.Infrastructure.Language;

namespace Piligrimm.Server.Infrastructure.Market
{
    public class CategoryInfrastructure : ICategoryInfrastructure
    {
        private readonly IInfrastructureContext _infrastructure;

        public CategoryInfrastructure(IInfrastructureContext infrastructure)
        {
            _infrastructure = infrastructure;
        }

        public IEnumerable<CategoryEntity> GetAll()
        {
            return _infrastructure.Category.ToEnumerable();
        }
    }
}