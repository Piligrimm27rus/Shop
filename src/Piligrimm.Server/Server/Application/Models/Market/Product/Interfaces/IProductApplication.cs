namespace Piligrimm.Server.Application.Models.Market
{
    public interface IProductApplication
    {
        IEnumerable<Product> GetAll();
    }
}