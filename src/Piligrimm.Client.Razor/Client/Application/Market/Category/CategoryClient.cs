using System.Net.Http.Json;
using Piligrimm.Client.Razor.Models.Market;

namespace Piligrimm.Client.Razor.Application.Market
{
    public class CategoryClient : ICategoryClient
    {
        private readonly MarketClient _client;

        public CategoryClient(MarketClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Category>?> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<IEnumerable<Category>>("market/category/getAll");
        }
    }
}