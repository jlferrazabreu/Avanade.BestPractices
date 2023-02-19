using Avanade.BestPratices.Infra.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.BestPratices.Domain.Entities
{
    public class DocumentParameter : EntityBase
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}
