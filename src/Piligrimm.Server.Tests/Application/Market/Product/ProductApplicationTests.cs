using Piligrimm.Server.Application.Market;
using Piligrimm.Server.Application.Models.Market;
using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.ServerTests.Application.Market
{
    public class ProductApplicationTests
    {
        private readonly ProductApplication productApplication;
        private readonly IProductInfrastructure productInfrastructure;
        private readonly IProductResolver productResolver;
        Fixture fixture = new();

        public ProductApplicationTests()
        {
            productInfrastructure = Substitute.For<IProductInfrastructure>();
            productResolver = new ProductResolver();

            productApplication = new(productInfrastructure, productResolver);
        }

        [Test]
        public void Test_GetAllNotEmpty()
        {
            IEnumerable<ProductEntity> productsEntity = fixture.Build<ProductEntity>()
                .WithAutoProperties()
                .CreateMany(3);
            productInfrastructure.GetAll().Returns(productsEntity);

            var products = productApplication.GetAll();

            Assert.IsNotNull(products);
            Assert.IsTrue(products.Count() != 0);
            Assert.IsTrue(products.First() is Product);
        }
    }
}