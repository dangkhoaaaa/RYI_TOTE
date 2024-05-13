using RYI_TOTE.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class Session : EntityBase<Guid>
    {
        public Guid MentorId { get; set; }

        public float Duration { get; set; }

        public float Price { get; set; }

        public string SessionName {  get; set; } 
    }
}
