using RYI_TOTE.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class MentorApplicationQuestion : EntityBase<Guid>
    {
        public string Content { get; set; }

        public string AnswerId {  get; set; }


    }
}
