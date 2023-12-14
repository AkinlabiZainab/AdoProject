using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Auditables;

namespace Desktop.LibrarySystemAdo.net.Core.Domain.Entities
{
    public class User : AuditableEntities
    {
        public string Email { get; set; }= default!;
        public string Password { get; set; } = default!;
        public string RoleName { get; set; } = default!;
        //  public Role Role { get; set; } = default!; 
    }
}