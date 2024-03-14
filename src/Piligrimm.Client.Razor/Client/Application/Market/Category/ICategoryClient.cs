using System.ComponentModel.DataAnnotations;
using Piligrimm.Client.Razor.Models.Market;


namespace Piligrimm.Client.Razor.Application.Market
{
    public interface ICategoryClient
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}