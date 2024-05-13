using RYI_TOTE.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class Assignment : EntityBase<Guid>
    {
        public string Title { get; set; }

        public string Description { get; set; } 

        public Guid MentorId { get; set; }

        public Guid MenteeId { get; set; }
    }
}
