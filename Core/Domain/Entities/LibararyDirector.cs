using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Auditables;

namespace Desktop.LibrarySystemAdo.net.Core.Domain.Entities
{
    public class LibararyDirector:AuditableEntities
    {
         public string StaffNumber {get; set;} = default!;
        public string ProfileId { get; set; } = default!;   
        // public Profile profile { get; set; }
    }
}