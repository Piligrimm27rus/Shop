using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Piligrimm.Server.Infrastructure
{
    public static class DbConfigurationExtention
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service, ConfigurationManager configuration)
        {
            service.AddDbContext<InfrastructureContext>(options =>
            {
                options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection"),
                x => x.MigrationsAssembly("Infrastructure"));
                options.UseSnakeCaseNamingConvention();
            });

            return service;
        }
    }
}