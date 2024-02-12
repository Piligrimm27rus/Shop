using Piligrimm.Server.Application.Market;
using Piligrimm.Server.Application.Models.Market;
using FluentAssertions;

namespace Piligrimm.ServerTests.Application.Market
{
    public class CategoryApplicationTests
    {
        private CategoryApplication categoryApplication;
        private ICategoryRepository categoryRepository;
        private CancellationToken cancellationToken;
        Fixture fixture = new();

        [SetUp]
        public void Setup()
        {
            categoryRepository = Substitute.For<ICategoryRepository>();
            categoryApplication = new(categoryRepository);
            cancellationToken = new CancellationToken();
        }

        [Test]
        public void Test_GetAllNotEmpty()
        {
            IEnumerable<Category> categoriesEntity = fixture.Build<Category>()
                .WithAutoProperties()
                .CreateMany(3);
            categoryRepository.GetAll(cancellationToken).Returns(categoriesEntity);

            var categories = categoryApplication.GetAll(cancellationToken).Result;

            Assert.IsNotNull(categories);
            Assert.IsTrue(categories.Count() != 0);
            Assert.IsTrue(categories.First() is Category);
        }

        [Test]
        public void Test_GetAllIsSame()
        {
            IEnumerable<Category> categoriesEntity = fixture.Build<Category>()
                .WithAutoProperties()
                .CreateMany(3);
            categoryRepository.GetAll(cancellationToken).Returns(categoriesEntity);

            var categories = categoryApplication.GetAll(cancellationToken).Result;

            categories.Should().Equal(categoriesEntity, (c1, c2) =>
                c1.Uid == c2.Uid &&
                c1.ParentId == c2.ParentId &&
                c1.Name == c2.Name &&
                c1.Description == c2.Description
            );
        }
    }
}