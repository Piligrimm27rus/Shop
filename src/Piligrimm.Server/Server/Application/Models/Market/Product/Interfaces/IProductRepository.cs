namespace Piligrimm.Server.Application.Models.Market
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}