namespace Piligrimm.Server.Application.Models.Market
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll(CancellationToken cancellationToken);
    }
}