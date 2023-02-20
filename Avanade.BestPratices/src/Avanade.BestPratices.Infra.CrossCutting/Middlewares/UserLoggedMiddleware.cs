using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Avanade.BestPratices.Infra.CrossCutting.Middlewares
{
    public class UserLoggedMiddleware
    {
        private readonly RequestDelegate _next;

        public UserLoggedMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var user = context.User;
            var username = user?.Identity?.Name;
            var userLoggedInfo = context.RequestServices.GetRequiredService<UserLoggedInfo>();
            userLoggedInfo.UserId = username ?? "System";

            await _next(context);
        }
    }
}
