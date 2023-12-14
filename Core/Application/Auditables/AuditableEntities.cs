using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desktop.LibrarySystemAdo.net.Core.Application.Auditables
{
    public class AuditableEntities
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
       
    }
}