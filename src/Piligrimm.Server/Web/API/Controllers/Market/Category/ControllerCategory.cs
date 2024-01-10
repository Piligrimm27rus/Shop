using Microsoft.AspNetCore.Mvc;
using Service.Market;
using Models.Market;

namespace Web.Market
{
    [Controller]
    [Route("api/market/category")]
    public class ControllerCategory : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public ControllerCategory(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Category> GetAll()
        {
            return categoryService.GetAll();
        }
    }
}