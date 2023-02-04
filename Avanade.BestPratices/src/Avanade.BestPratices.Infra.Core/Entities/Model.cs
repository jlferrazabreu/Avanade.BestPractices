using System;

namespace Avanade.BestPratices.Infra.Core.Entities
{
    public class Model : EntityBase
    {
        public Guid ManufactureId { get; set; }
        public Manufacture Manufacture { get; set; }

        public string Name { get; set; }

    }
}
