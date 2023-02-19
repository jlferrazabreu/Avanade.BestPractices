using Avanade.BestPratices.Domain.Entities.Enum;
using Avanade.BestPratices.Infra.Core.Entities;
using System;

namespace Avanade.BestPratices.Domain.Entities
{
    public class Document : EntityBase
    {
        public Guid AccountId { get; set; }
        public Account Account { get; set; }

        public DocumentType Type { get; set; }
        public string Number { get; set; }
    }
}
