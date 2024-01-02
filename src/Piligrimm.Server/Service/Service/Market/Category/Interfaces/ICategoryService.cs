using Models.Market;

namespace Service.Market
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
    }
}