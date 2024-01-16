using Models.Market;
using Service.Market;
using Application.Market;

namespace WebTests.Service.Market
{
    public class CategoryServiceTests
    {
        private CategoryService categoryService;
        Fixture fixture = new();

        [SetUp]
        public void Setup()
        {
            var application = Substitute.For<ICategoryApplication>();

            IEnumerable<Category> categories = fixture.Build<Category>()
                .WithAutoProperties()
                .CreateMany(3);

            application.GetAll().Returns(categories);

            categoryService = new(application);
        }

        [Test]
        public void Test_GetAllNotEmpty()
        {
            var categories = categoryService.GetAll();

            Assert.IsNotNull(categories);
            Assert.IsTrue(categories.Count() != 0);
        }
    }
}