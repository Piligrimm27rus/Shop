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
                cancellationToken.ThrowIfCancellationRequested();
            }

            return Task.FromResult(_infrastructure.Category.ToEnumerable());
        }
    }
}