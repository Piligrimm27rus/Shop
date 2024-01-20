using Microsoft.AspNetCore.Mvc;

using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.API.Controllers.Market
{
    [Controller]
    [Route("api/market/[controller]/[action]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryApplication _categoryApplication;

        public CategoryController(ICategoryApplication categoryApplication)
        {
            _categoryApplication = categoryApplication;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Category> GetAll()
        {
            return _categoryApplication.GetAll();
        }
    }
}