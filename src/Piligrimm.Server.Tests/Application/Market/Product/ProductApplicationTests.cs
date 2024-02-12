using Piligrimm.Server.Application.Market;
using Piligrimm.Server.Application.Models.Market;
using FluentAssertions;

namespace Piligrimm.ServerTests.Application.Market
{
    public class ProductApplicationTests
    {
        private ProductApplication productApplication;
        private IProductRepository productRepository;
        private CancellationToken cancellationToken;
        Fixture fixture = new();

        [OneTimeSetUp]
        public void Setup()
        {
            productRepository = Substitute.For<IProductRepository>();
            productApplication = new(productRepository);
            cancellationToken = new CancellationToken();
        }

        [Test]
        public void Test_GetAllNotEmpty()
        {
            IEnumerable<Product> productsEntity = fixture.Build<Product>()
                .WithAutoProperties()
                .CreateMany(3);
            productRepository.GetAll(cancellationToken).Returns(productsEntity);

            var products = productApplication.GetAll(cancellationToken).Result;

            Assert.IsNotNull(products);
            Assert.IsTrue(products.Count() != 0);
            Assert.IsTrue(products.First() is Product);
        }

        [Test]
        public void Test_GetAllIsSame()
        {
            IEnumerable<Product> productsEntity = fixture.Build<Product>()
                .WithAutoProperties()
                .CreateMany(3);
            productRepository.GetAll(cancellationToken).Returns(productsEntity);

            var products = productApplication.GetAll(cancellationToken).Result;

            products.Should().Equal(productsEntity, (p1, p2) =>
                p1.Uid == p2.Uid &&
                p1.Category == p2.Category &&
                p1.Name == p2.Name &&
                p1.Price == p2.Price &&
                p1.Discount == p2.Discount &&
                p1.Description == p2.Description
            );
        }
    }
}