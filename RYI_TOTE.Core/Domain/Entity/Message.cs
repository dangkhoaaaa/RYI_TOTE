using RYI_TOTE.Core.Base;
using RYI_TOTE.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class Message : EntityBase<Guid>
    {
        public Guid SenderId { get; set; }


        public Guid Receiveld {  get; set; }

        public string Content { get; set; }

        public DateTime SendDate { get; set; }

        public MessageStatus Status {  get; set; }
  
        
    }
}
