using Avanade.BestPratices.Infra.Core.Entities.Services;
using Avanade.BestPratices.Service.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Avanade.BestPratices.Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IService<>), typeof(ServiceBase<>));
        }
    }
}
