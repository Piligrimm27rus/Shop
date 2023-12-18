using ProductOrder.Controllers;

public interface IoContainer
{
    void Load(IServiceCollection services);
}

public static class NinjectDependenses
{
	public static void LoadDependenses(IServiceCollection services)
    {
        var modules = new IoContainer[]
        {
            new ControllersDependerServices()
        };

        foreach (var ioc in modules)
        {
            ioc.Load(services);
        }
    }
}
