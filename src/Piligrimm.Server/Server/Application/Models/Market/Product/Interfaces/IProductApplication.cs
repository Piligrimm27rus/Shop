namespace Piligrimm.Server.Application.Models.Market
{
    public interface IProductApplication
    {
        Task<IEnumerable<Product>> GetAll(CancellationToken cancellation);
    }
}