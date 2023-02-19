using Avanade.BestPratices.Domain.Entities.Enum;
using Avanade.BestPratices.Domain.ValueObjects;
using Avanade.BestPratices.Infra.Core.Entities;
using System;

namespace Avanade.BestPratices.Domain.Entities
{
    public class Charge : EntityBase
    {
        public Guid RideId { get; set; }
        public Ride Ride { get; set; }

        public Money GrossValue { get; set; }
        public Money DiscountValue { get; set; }
        public Money NetValue { get; set; }
        public ChargeStatus Status { get; set; }
        public string Description { get; set; }
    }
}
