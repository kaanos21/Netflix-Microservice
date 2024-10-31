
using Netflix.WebUı.Settings;

namespace Netflix.WebUı.Extensions.ServiceApiSetting
{
    public static class ServiceApiSettingsExtensions
    {
        public static IServiceCollection AddServiceApiSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Settings.ServiceApiSettings>(configuration.GetSection("ServiceApiSettings"));
            return services;
        }
    }
}
