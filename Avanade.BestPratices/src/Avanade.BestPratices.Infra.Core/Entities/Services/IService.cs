using Avanade.BestPratices.Infra.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.BestPratices.Infra.Core.Entities.Services
{
    public interface IService<T> where T : IEntity
    {
    }

    public interface IService
    {
    }
}
