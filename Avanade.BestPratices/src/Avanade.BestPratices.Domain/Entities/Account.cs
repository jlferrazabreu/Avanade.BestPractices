using Avanade.BestPratices.Infra.Core.Entities;
using System;

namespace Avanade.BestPratices.Domain.Entities
{
    public class Account : EntityBase
    {
        public string Name { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public bool IsAproved { get; set; }
    }
}
