namespace Piligrimm.Server.Application.Models.Market
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
    }
}