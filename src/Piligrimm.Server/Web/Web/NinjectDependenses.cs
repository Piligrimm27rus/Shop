using Common.IoC;
using Service;
using Application;

public static class NinjectDependenses
{
    public static void LoadDependenses(IServiceCollection services)
    {
        var modules = new IoContainer[]
        {
            new ServiceDepender(),
            new ApplicationDepender(),
        };

        foreach (var ioc in modules)
        {
            ioc.Load(services);
        }
    }
}