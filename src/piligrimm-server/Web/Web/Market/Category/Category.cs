using Microsoft.AspNetCore.Mvc;
using Service.Market;

namespace Web.Market
{
    [Controller]
    [Route("Market/[controller]")]
    public class Category : ControllerBase
    {
        private readonly IServiceCategory serviceCategory;

        public Category(IServiceCategory _serviceCategory)
        {
            serviceCategory = _serviceCategory;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Models.Market.Category> GetAll()
        {
            return serviceCategory.GetAll();
        }
    }
}