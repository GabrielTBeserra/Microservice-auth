using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Base;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Base.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Config;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Config.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.User;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.User.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AUTH_SERVICE_SERVICE.DependencyInjection.UnitOfWorkInjection
{
    public static class ConfigureBindinsUnifOfWorks
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAuthUnitOfWork, AuthUnitOfWork>();
            services.AddScoped<IBaseConfigUnitOfWork, BaseConfigUnitOfWork>();
            services.AddScoped<IBaseUnitOfWork, BaseUnitOfWork>();
        }
    }
}
