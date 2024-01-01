using Models.Market;

namespace Service.Market
{
    public interface ICategoryService
    {
        public IEnumerable<Category> GetAll();
    }
}