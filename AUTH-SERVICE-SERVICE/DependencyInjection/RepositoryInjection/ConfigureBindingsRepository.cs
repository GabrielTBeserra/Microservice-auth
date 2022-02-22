using AUTH_SERVICE_INFRASTRUCTURE.Repositories.Audit;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.Audit.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.User;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.User.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AUTH_SERVICE_SERVICE.DependencyInjection.RepositoryInjection
{
    public static class ConfigureBindingsRepository
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ILogRepository, LogRepository>();
        }

    }
}
