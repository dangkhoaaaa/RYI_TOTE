using RYI_TOTE.Core.Base;
using RYI_TOTE.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class MentorApplication : EntityBase<Guid>
    {
        public Guid UserId { get; set; }

        public DateTime ApplicationDate { get; set; }

        public MentorApplicationStatus Status { get; set; }

    }
}
