using Microsoft.Extensions.DependencyInjection;
using NotificationAndResult.Core.Application.Interfaces;
using NotificationAndResult.Core.Utils.NotificationObjects;
using Validations.Core.Application.Services;

namespace NotificationAndResult.Core
{
    public static class DependencyInjection
    {
        public static void AddCore(this IServiceCollection services)
        {
            services.AddScoped<NotificationContext>();

            services.AddScoped<IUserAppService, UserAppService>();
        }
    }
}
