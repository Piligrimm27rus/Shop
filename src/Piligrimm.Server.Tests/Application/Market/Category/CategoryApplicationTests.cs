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
        public async Task GetAll_CategoryRepositoryHasRows_NotNullAndGetAllIsSame()
        {
            IEnumerable<Category> categoriesEntity = fixture.Build<Category>()
                .WithAutoProperties()
                .CreateMany(3);
            categoryRepository.GetAll(cancellationToken).Returns(categoriesEntity);

            var categories = await categoryApplication.GetAll(cancellationToken);

            Assert.IsNotNull(categories);
            Assert.IsTrue(categories.Count() != 0);
            Assert.IsTrue(categories.First() is Category);
            // categories.Should().BeEquivalentTo(categoriesEntity);
            categories.Should().Equal(categoriesEntity, (c1, c2) =>
                c1.Uid == c2.Uid &&
                c1.ParentId == c2.ParentId &&
                c1.Name == c2.Name &&
                c1.Description == c2.Description
            );
        }
    }
}