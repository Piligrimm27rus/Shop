using Microsoft.AspNetCore.Mvc;

using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.API.Controllers.Market
{
    [Controller]
    [Route("api/market/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplication _productApplication;

        public ProductController(IProductApplication productApplication)
        {
            _productApplication = productApplication;
        }

        [HttpGet]
        public Task<IEnumerable<Product>> GetAll(CancellationToken cancellationToken)
        {
            return _productApplication.GetAll(cancellationToken);
        }
    }
}