using Avanade.BestPratices.Infra.Core.Entities;
using System;

namespace Avanade.BestPratices.Domain.Entities
{
    public class Ride : EntityBase
    {
        public Guid AccountId { get; set; }
        public Account Account { get; set; }

        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public int Distance { get; set; }
        public bool IsActive { get; set; }
    }
}
