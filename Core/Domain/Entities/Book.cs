using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Auditables;
using Desktop.LibrarySystemAdo.net.Core.Domain.Enum;

namespace Desktop.LibrarySystemAdo.net.Core.Domain.Entities
{
    public class Book : AuditableEntities
    {
        public string Title { get; set; } = default !;
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public string Version {get; set;}
        public int Copies {get; set;}
        //public int TotalCopies { get; set; }
       
    }
}