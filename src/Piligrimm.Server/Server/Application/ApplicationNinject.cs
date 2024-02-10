using Ninject.Modules;

using Piligrimm.Server.Application.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Application
{
    public class ApplicationNinject : NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind<ICategoryApplication>().To<CategoryApplication>().InSingletonScope();
            this.Kernel.Bind<IProductApplication>().To<ProductApplication>().InSingletonScope();
        }
    }
}