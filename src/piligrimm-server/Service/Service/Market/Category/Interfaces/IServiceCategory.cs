using Models.Market;

namespace Service.Market
{
    public interface IServiceCategory
    {
        public IEnumerable<Category> GetAll();
    }
}