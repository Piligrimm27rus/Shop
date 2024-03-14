using Piligrimm.Client.Razor.Models.Market;
using Piligrimm.Client.Razor.Application.Market;

namespace Piligrimm.Client.Razor.Service.Market
{
    internal class CategoryService : ICategoryService
    {
        private readonly ICategoryClient _client;
        public CategoryService(ICategoryClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var categories = await _client.GetAllAsync();
            
            return categories;
        }

        public Task<IEnumerable<Category>> GetAllMock()
        {
            var categories = new List<Category>()
            {
                new Category() { Uid = new Guid("f0099baa-9fa7-49a0-8a6e-e68070c06da7"), Name = "Laptop",         Description = "Description of Category", ParentId = null },
                new Category() { Uid = new Guid("0975ab3f-2323-4397-b84e-0f6dbd7b92fc"), Name = "Phone",          Description = "Description of Category", ParentId = null },
                new Category() { Uid = new Guid("5008a582-fcdc-4059-826a-3ea838ac6d96"), Name = "Vacuum cleaner", Description = "Description of Category", ParentId = null },
                new Category() { Uid = new Guid("d67bb71f-f097-43bd-938e-582862f4a973"), Name = "Computer",       Description = "Description of Category", ParentId = null },
                new Category() { Uid = new Guid("020b46a1-affc-420c-92ee-d02e686d846c"), Name = "HDD",            Description = "Description of Category", ParentId = null },
                new Category() { Uid = new Guid("1c687127-9bdf-44db-9650-3b9c193b947a"), Name = "Flash drive",    Description = "Description of Category", ParentId = null },
            };

            return Task.FromResult(categories.AsEnumerable());
        }
    }
}