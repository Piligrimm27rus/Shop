using Piligrimm.Client.Razor.Models.Market;

namespace Piligrimm.Client.Razor.Provider.Market
{
    internal class CategoryProvider : ICategoryProvider
    {
        public Task<IEnumerable<Category>> GetAll()
        {
            var a = Enumerable<Category>.Range(0, 5).Select(c => {
                
            });
            return a;
        }
    }
}