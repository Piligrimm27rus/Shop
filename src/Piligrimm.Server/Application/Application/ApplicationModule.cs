using Ninject.Modules;

using Application.Market;

namespace Application
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind<ICategoryApplication>().To<CategoryApplication>().InSingletonScope();
        }
    }
}