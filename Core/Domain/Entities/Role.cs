using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Auditables;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;

namespace Desktop.LibrarySystemAdo.net.Core.Domain
{
    public class Role :AuditableEntities
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
       // public string UserId { get; set; } = default!;
        //public ICollection<User> Users { get; set; }

    }
}