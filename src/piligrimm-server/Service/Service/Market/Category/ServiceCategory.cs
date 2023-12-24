using Application.Market;
using Models.Market;

namespace Service.Market
{
    public class ServiceCategory : IServiceCategory
    {
        private readonly IApplicationCategory applicationCategory;

        public ServiceCategory(IApplicationCategory _applicationCategory)
        {
            applicationCategory = _applicationCategory;
        }

        public IEnumerable<Category> GetAll()
        {
            return applicationCategory.GetAll();
        }
    }
}