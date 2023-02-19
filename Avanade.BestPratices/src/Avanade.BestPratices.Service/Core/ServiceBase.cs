using Avanade.BestPratices.Infra.Core.Entities.Interfaces;
using Avanade.BestPratices.Infra.Core.Entities.Services;

namespace Avanade.BestPratices.Service.Core
{
    public class ServiceBase<T> : IService<T> where T : IEntity
    {
    }
}
