using RYI_TOTE.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class Mentorship : EntityBase<Guid>
    {
        public Guid MenteeId { get; set; }

        public Guid MentorId { get; set; }

        public DateTime ConnectedDate { get; set; }

        public string ReletionshipType { get; set; }
    }
}
