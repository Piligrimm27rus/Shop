using Microsoft.AspNetCore.Mvc;
using Service.Market;

namespace Web.Market
{
    [Controller]
    [Route("market/category")]
    public class ControllerCategory : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public ControllerCategory(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Models.Market.Category> GetAll()
        {
            return categoryService.GetAll();
        }
    }
}