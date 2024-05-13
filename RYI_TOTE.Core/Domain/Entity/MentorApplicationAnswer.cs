using RYI_TOTE.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class MentorApplicationAnswer : EntityBase<Guid>
    { 
        public string Content { get; set; }

        public Guid MentorPlanId { get; set; }
    }
}
