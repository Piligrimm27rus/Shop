using NUnit.Framework.Internal;
using Application.Market;

namespace TestWeb.Services.Market
{
    public class TestsCategoryApplication
    {
        private CategoryApplication categoryApplication;

        [SetUp]
        public void Setup()
        {
            categoryApplication = new CategoryApplication();
        }

        [Test]
        public void Test_GetAllNotEmpty()
        {
            var allCategories = categoryApplication.GetAll();

            Assert.IsNotNull(allCategories);
            Assert.True(allCategories.Count() != 0);
        }
    }
}