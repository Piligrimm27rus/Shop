using Piligrimm.Server.Application.Market;
using Piligrimm.Server.Application.Models.Market;
using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.ServerTests.Application.Market
{
    public class ProductApplicationTests
    {
        private readonly ProductApplication productApplication;
        private readonly IProductRepository productRepository;
        Fixture fixture = new();

        public ProductApplicationTests()
        {
            productRepository = Substitute.For<IProductRepository>();
            productApplication = new(productRepository);
        }

        [Test]
        public void Test_GetAllNotEmpty()
        {
            IEnumerable<Product> productsEntity = fixture.Build<Product>()
                .WithAutoProperties()
                .CreateMany(3);
            productRepository.GetAll().Returns(productsEntity);

            var products = productApplication.GetAll();

            Assert.IsNotNull(products);
            Assert.IsTrue(products.Count() != 0);
            Assert.IsTrue(products.First() is Product);
        }
    }
}