namespace Piligrimm.Server.Application.Models.Market
{
    public interface ICategoryApplication
    {
        IEnumerable<Category> GetAll();
    }
}