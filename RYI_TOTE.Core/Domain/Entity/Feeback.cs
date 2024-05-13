using RYI_TOTE.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class Feeback : EntityBase<Guid>
    {
        public Guid MentorshipId { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime? CreatedDate { get; set;}
    }
}
