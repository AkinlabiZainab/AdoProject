using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Auditables;

namespace Desktop.LibrarySystemAdo.net.Core.Domain.Entities
{
    public class Lender :AuditableEntities
    {
         public string ProfileID { get; set; }
        // public Profile Profile { get; set; }
        public string RefNumber { get; set; }
        public string BookId { get; set; }
      // public ICollection<Book> BooksT { get; set; } = new HashSet<Book>();
        public DateTime DateBorrowed { get; set; }

    }
}