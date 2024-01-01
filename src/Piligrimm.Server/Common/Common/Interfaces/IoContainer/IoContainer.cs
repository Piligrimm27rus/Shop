using Microsoft.Extensions.DependencyInjection;

namespace Common.IoC
{
    public interface IoContainer
    {
        void Load(IServiceCollection services);
    }
}