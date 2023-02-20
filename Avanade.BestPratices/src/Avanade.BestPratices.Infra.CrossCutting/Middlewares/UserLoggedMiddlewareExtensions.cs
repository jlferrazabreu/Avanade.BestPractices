using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Avanade.BestPratices.Infra.CrossCutting.Middlewares
{
    public static class UserLoggedMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggedInfo(this IApplicationBuilder app)
        {
            return app.UseMiddleware<UserLoggedMiddleware>();
        }

        public static void AddUserLoggedInfoDependency(this IServiceCollection services)
        {
            services.AddScoped<UserLoggedInfo>();
        }
    }
}
