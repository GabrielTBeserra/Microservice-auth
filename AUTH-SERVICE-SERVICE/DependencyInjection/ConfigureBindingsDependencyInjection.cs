using AUTH_SERVICE_SERVICE.DependencyInjection.ApplicationServiceInjection;
using AUTH_SERVICE_SERVICE.DependencyInjection.RepositoryInjection;
using AUTH_SERVICE_SERVICE.DependencyInjection.UnitOfWorkInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AUTH_SERVICE_SERVICE.DependencyInjection
{
    public static class ConfigureBindingsDependencyInjection
    {

        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureBindingsApplicationService.RegisterBindings(services, configuration);
            ConfigureBindingsRepository.RegisterBindings(services, configuration);
            ConfigureBindinsUnifOfWorks.RegisterBindings(services, configuration);
        }
    }
}