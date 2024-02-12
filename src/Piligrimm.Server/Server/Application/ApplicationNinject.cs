using Ninject.Modules;
using Ninject.Web.Common;

using Piligrimm.Server.Application.Market;
using Piligrimm.Server.Application.Models.Market;

namespace Piligrimm.Server.Application
{
    public class ApplicationNinject : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<ICategoryApplication>().To<CategoryApplication>().InRequestScope();
            Kernel.Bind<IProductApplication>().To<ProductApplication>().InRequestScope();
        }
    }
}