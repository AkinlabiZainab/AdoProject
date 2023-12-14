using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Auditables;
using Desktop.LibrarySystemAdo.net.Core.Domain.Enum;

namespace Desktop.LibrarySystemAdo.net.Core.Domain.Entities
{
    public class Profile :AuditableEntities
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; }= default!;
        public string PhoneNumber { get; set; } = default!;
        public Gender Gender { get; set; }
        public string Address { get; set; }= default!;
        public string UserId {get; set;}
        // public User user { get; set; } = default!;
        public string Image { get; set; } = default!;
    }
}