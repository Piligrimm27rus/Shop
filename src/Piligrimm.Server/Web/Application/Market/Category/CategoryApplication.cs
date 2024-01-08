using System.Collections.Generic;
using Models.Market;

namespace Application.Market
{
    public class CategoryApplication : ICategoryApplication
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<Category> GetAll()
        {
            return Enumerable.Range(1, 5).Select(index => new Category
            {
                Uid = new Guid(),
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}