using Piligrimm.Client.Razor.Models.Market;

namespace Piligrimm.Client.Razor.Provider.Market
{
    internal interface ICategoryProvider
    {
        Task<IEnumerable<Category>> GetAll();
    }
}