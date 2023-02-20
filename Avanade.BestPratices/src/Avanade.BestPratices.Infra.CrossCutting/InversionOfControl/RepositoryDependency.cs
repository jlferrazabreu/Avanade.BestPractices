using Avanade.BestPratices.Infra.Core.Entities.Interfaces;
using Avanade.BestPratices.Infra.Data.Repositories.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Avanade.BestPratices.Infra.CrossCutting.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepositoryDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
        }
    }
}
