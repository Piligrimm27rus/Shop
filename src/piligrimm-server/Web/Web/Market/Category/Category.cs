using Microsoft.AspNetCore.Mvc;
using Service.Market;

namespace Web.Market
{
    [Controller]
    [Route("[controller]")]
    public class Category : ControllerBase
    {
        private readonly ILogger<Category> _logger;
        private readonly IServiceCategory serviceCategory;

        public Category(ILogger<Category> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Models.Market.Category> GetAll()
        {
            return serviceCategory.GetAll();
        }
    }
}

