namespace Piligrimm.Server.Application.Models.Market
{
    public interface ICategoryApplication
    {
        Task<IEnumerable<Category>> GetAll(CancellationToken cancellationToken);
    }
}