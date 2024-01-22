using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.Server.Infrastructure.Market
{
    public class CategoryInfrastructure : ICategoryInfrastructure
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<CategoryDto> GetAll()
        {
            return Enumerable.Range(1, 5).Select(index => new CategoryDto
            {
                Uid = Guid.NewGuid(),
                Name = Summaries[Random.Shared.Next(Summaries.Length)],
                Price = Random.Shared.Next(0, 100),
                Description = string.Empty
            }).ToArray();
        }
    }
}