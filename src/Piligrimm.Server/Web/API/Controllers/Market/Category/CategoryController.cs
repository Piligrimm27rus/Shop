using Microsoft.AspNetCore.Mvc;
using Service.Market;
using Models.Market;

namespace API.Controllers.Market
{
    [Controller]
    [Route("api/market/category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
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