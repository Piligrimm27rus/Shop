using Piligrimm.Server.Application.Market;
using Piligrimm.Server.Application.Models.Market;
using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.ServerTests.Application.Market
{
    public class CategoryApplicationTests
    {
        private CategoryApplication categoryApplication;
        Fixture fixture = new();

        [SetUp]
        public void Setup()
        {
            var categoryInfrastructure = Substitute.For<ICategoryInfrastructure>();

            IEnumerable<CategoryDto> categories = fixture.Build<CategoryDto>()
                .WithAutoProperties()
                .CreateMany(3);

            categoryInfrastructure.GetAll().Returns(categories);

            categoryApplication = new(categoryInfrastructure);
        }

        [Test]
        public void Test_GetAllNotEmpty()
        {
            var categories = categoryApplication.GetAll();

            Assert.IsNotNull(categories);
            Assert.IsTrue(categories.Count() != 0);
            Assert.IsTrue(categories.First() is Category);
        }
    }
}