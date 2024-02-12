using Piligrimm.Server.Application.Models.Market;
using Ninject.Infrastructure.Language;

namespace Piligrimm.Server.Infrastructure.Market
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly InfrastructureContext _infrastructure;

        public CategoryRepository(InfrastructureContext infrastructure)
        {
            _infrastructure = infrastructure;
        }

        public Task<IEnumerable<Category>> GetAll(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromResult(Enumerable.Empty<Category>());
            }

            var categories = _infrastructure.Category.ToEnumerable();
            return Task.FromResult(categories.Cast());
        }
    }
}