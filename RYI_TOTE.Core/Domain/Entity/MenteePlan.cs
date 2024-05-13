using RYI_TOTE.Core.Base;
using RYI_TOTE.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class MenteePlan : EntityBase<Guid>
    {
        public Guid MentorId { get; set; }

        public string Description { get; set; }

        public float TotalSlot { get; set; }

        public MenteePlanStatus Status { get; set; }

        public float Price { get; set; }
    }
}
