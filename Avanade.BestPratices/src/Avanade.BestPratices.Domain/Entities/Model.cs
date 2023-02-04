using Avanade.BestPratices.Infra.Core.Entities;
using System;

namespace Avanade.BestPratices.Domain.Entities
{
    public class Model : EntityBase
    {
        public Guid ManufactureId { get; set; }
        public Manufacture Manufacture { get; set; }

        public string Name { get; set; }

    }
}
