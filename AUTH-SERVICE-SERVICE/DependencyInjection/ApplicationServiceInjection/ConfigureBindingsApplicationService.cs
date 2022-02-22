using AUTH_SERVICE_SERVICE.ApplicationService.Auth;
using AUTH_SERVICE_SERVICE.ApplicationService.Auth.Interfaces;
using AUTH_SERVICE_SERVICE.ApplicationService.Config;
using AUTH_SERVICE_SERVICE.ApplicationService.Config.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AUTH_SERVICE_SERVICE.DependencyInjection.ApplicationServiceInjection
{
    public static class ConfigureBindingsApplicationService
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITokenApplicationService, TokenApplicationService>();
            services.AddScoped<IBaseApplicationService, BaseApplicationService>();

            #region AUTH
            services.AddScoped<IAuthApplicationService, AuthApplicationService>();
            #endregion
        }
    }
}
