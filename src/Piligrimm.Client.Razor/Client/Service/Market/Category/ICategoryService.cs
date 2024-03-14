using Piligrimm.Client.Razor.Models.Market;

namespace Piligrimm.Client.Razor.Service.Market
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAll();
    }
}