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

        [HttpGet]
        public Task<IEnumerable<Category>> GetAll(CancellationToken cancellationToken)
        {
            return _categoryApplication.GetAll(cancellationToken);
        }
    }
}