using Models.Market;

namespace Application.Market
{
    public interface IApplicationCategory
    {
        public IEnumerable<Category> GetAll();
    }
}