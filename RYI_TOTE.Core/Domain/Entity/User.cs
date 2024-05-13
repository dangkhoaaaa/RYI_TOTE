using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace RYI_TOTE.Core.Domain.Entity
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; } = null!;
        public string? BankAccount { get; set; }
        public string? PhotoUrl { get; set; }
        public string? Gender { get; set; }
        public bool Status { get; set; }

       
    }
}
