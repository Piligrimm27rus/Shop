using Microsoft.Extensions.DependencyInjection;
using Common.IoC;
using Service.Market;
using Application.Market;

namespace Service
{
    public class ServiceDepender : IoContainer
    {
        public void Load(IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
        }
    }
}