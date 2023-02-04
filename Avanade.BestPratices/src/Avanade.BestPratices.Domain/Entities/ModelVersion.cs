using Avanade.BestPratices.Infra.Core.Entities;
using System;

namespace Avanade.BestPratices.Domain.Entities
{
    public class ModelVersion : EntityBase
    {
        public Guid ModelId { get; set; }
        public Model Model { get; set; }

        public string Name { get; set; }
    }
}
