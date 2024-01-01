using Models.Market;

namespace Application.Market
{
    public interface ICategoryApplication
    {
        public IEnumerable<Category> GetAll();
    }
}