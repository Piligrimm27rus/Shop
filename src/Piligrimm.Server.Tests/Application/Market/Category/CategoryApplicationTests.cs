using Piligrimm.Server.Application.Market;
using Piligrimm.Server.Application.Models.Market;
using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.ServerTests.Application.Market
{
    public class CategoryApplicationTests
    {
        private readonly CategoryApplication categoryApplication;
        private readonly ICategoryRepository categoryRepository;
        Fixture fixture = new();

        public CategoryApplicationTests()
        {
            categoryRepository = Substitute.For<ICategoryRepository>();
            categoryApplication = new(categoryRepository);
        }

        [Test]
        public void Test_GetAllNotEmpty()
        {
            IEnumerable<Category> categoriesEntity = fixture.Build<Category>()
                .WithAutoProperties()
                .CreateMany(3);
            categoryRepository.GetAll().Returns(categoriesEntity);

            var categories = categoryApplication.GetAll();

            Assert.IsNotNull(categories);
            Assert.IsTrue(categories.Count() != 0);
            Assert.IsTrue(categories.First() is Category);
        }
    }
}