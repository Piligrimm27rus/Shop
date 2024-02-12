using Ninject.Modules;
using Ninject.Web.Common;
using Piligrimm.Server.Application.Models.Market;
using Piligrimm.Server.Infrastructure.Market;

namespace Piligrimm.Server.Infrastructure
{
    public class InfrastructureNinject : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<ICategoryRepository>().To<CategoryRepository>().InRequestScope();
            Kernel.Bind<IProductRepository>().To<ProductRepository>().InRequestScope();
        }
    }
}