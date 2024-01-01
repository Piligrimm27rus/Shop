using Microsoft.Extensions.DependencyInjection;
using Common.IoC;
using Application.Market;

namespace Application
{
    public class ApplicationDepender : IoContainer
    {
        public void Load(IServiceCollection services)
        {
            services.AddTransient<ICategoryApplication, CategoryApplication>();
        }
    }
}