using Piligrimm.Server.Application.Market;
using Piligrimm.Server.Application.Models.Market;
using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.ServerTests.Application.Market
{
    public class CategoryApplicationTests
    {
        private readonly CategoryApplication categoryApplication;
        private readonly ICategoryInfrastructure categoryInfrastructure;
        private readonly ICategoryResolver categoryResolver;
        Fixture fixture = new();

        public CategoryApplicationTests()
        {
            categoryInfrastructure = Substitute.For<ICategoryInfrastructure>();
            categoryResolver = new CategoryResolver();

            categoryApplication = new(categoryInfrastructure, categoryResolver);
        }

        [Test]
        public void Test_GetAllNotEmpty()
        {
            IEnumerable<CategoryEntity> categoriesEntity = fixture.Build<CategoryEntity>()
                .WithAutoProperties()
                .CreateMany(3);
            categoryInfrastructure.GetAll().Returns(categoriesEntity);

            var categories = categoryApplication.GetAll();

            Assert.IsNotNull(categories);
            Assert.IsTrue(categories.Count() != 0);
            Assert.IsTrue(categories.First() is Category);
        }
    }
}