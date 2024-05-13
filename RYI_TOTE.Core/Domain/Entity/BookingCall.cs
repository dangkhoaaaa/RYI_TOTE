using RYI_TOTE.Core.Base;
using RYI_TOTE.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class BookingCall : EntityBase<Guid>
    {
        public DateTime BookingTime { get; set; }

        public DateTime TimeStart { get; set; }

        public string Description { get; set; }

        public BookingCallStatus Status { get; set; }
        public Guid SessionId { get; set; }
    }
}
