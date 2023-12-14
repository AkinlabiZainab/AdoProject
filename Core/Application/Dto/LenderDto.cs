using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;

namespace Desktop.LibrarySystemAdo.net.Core.Application.Dto
{
    public class LenderDto
    {
        public string Id { get; set; }
        public string ProfileID { get; set; }
        // public Profile Profile { get; set; }
        public string RefNumber { get; set; }
        public Book Booking { get; set; }
        public bool isDeleted { get; set; }
        public string BookId { get; set; }
       // public ICollection<BookDto> Book { get; set; } = new HashSet<BookDto>();
        public DateTime DateBorrowed { get; set; }
        public bool isReturned { get; set; }
        public DateTime DateReturned { get; set; }
            
    }
}