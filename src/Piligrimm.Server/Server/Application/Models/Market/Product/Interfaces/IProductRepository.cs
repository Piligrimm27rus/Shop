namespace Piligrimm.Server.Application.Models.Market
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll(CancellationToken cancellation);
    }
}