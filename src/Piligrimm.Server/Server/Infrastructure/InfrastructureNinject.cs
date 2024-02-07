using Ninject.Modules;

using Piligrimm.Server.Infrastructure.Market;
using Piligrimm.Server.Infrastructure.Models.Market;

namespace Piligrimm.Server.Infrastructure
{
    public class InfrastructureNinject : NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind<ICategoryInfrastructure>().To<CategoryInfrastructure>().InSingletonScope();
            this.Kernel.Bind<IProductInfrastructure>().To<ProductInfrastructure>().InSingletonScope();

            this.Kernel.Bind<IInfrastructureContext>().To<InfrastructureContext>().InTransientScope();
        }
    }
}