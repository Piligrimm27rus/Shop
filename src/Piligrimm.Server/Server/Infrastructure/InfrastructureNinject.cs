using Ninject.Modules;
using Piligrimm.Server.Application.Models.Market;
using Piligrimm.Server.Infrastructure.Market;
using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.Server.Infrastructure
{
    public class InfrastructureNinject : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<ICategoryRepository>().To<CategoryRepository>().InThreadScope();
            Kernel.Bind<IProductRepository>().To<ProductRepository>().InThreadScope();

            Kernel.Bind<IProductResolver>().To<ProductResolver>().InSingletonScope();
            Kernel.Bind<ICategoryResolver>().To<CategoryResolver>().InSingletonScope();
        }
    }
}