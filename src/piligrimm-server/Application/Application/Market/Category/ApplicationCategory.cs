using System.Collections.Generic;
using Models.Market;

namespace Application.Market
{
    public class ApplicationCategory : IApplicationCategory
    {
        // private readonly IApplicationCategory applicationCategory;
        
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        // public ApplicationCategory(IApplicationCategory _applicationCategory)
        // {
        //     applicationCategory = _applicationCategory;
        // }

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