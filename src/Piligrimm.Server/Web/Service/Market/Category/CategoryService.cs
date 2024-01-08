using Application.Market;
using Models.Market;

namespace Service.Market
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryApplication categoryApplication;

        public CategoryService(ICategoryApplication _categoryApplication)
        {
            categoryApplication = _categoryApplication;
        }

        public IEnumerable<Category> GetAll()
        {
            return categoryApplication.GetAll();
        }
    }
}