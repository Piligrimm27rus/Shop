using Ninject.Modules;

using Service.Market;
using Application.Market;

namespace Service
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind<ICategoryService>().To<CategoryService>().InSingletonScope();
        }
    }
}