using Avanade.BestPratices.Infra.CrossCutting.Middlewares;
using Avanade.BestPratices.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Avanade.BestPratices.Infra.CrossCutting.InversionOfControl
{
    public static class EntityDependency
    {
        public static IServiceCollection AddEntityDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(ServiceProvider =>
            {
                var connectionSring = configuration.GetConnectionString("BestPractices");
                var options = new DbContextOptionsBuilder<EntityContext>()
                .UseSqlServer(connectionSring)
                .Options;
                var userLoggedInfo = (UserLoggedInfo)ServiceProvider.GetService(typeof(UserLoggedInfo));
                var context = new EntityContext(options, userLoggedInfo?.UserId);
                return context;
            });

            return services;
        }
    }
}
