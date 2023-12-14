using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;

namespace LibrarySystemAdo.net.Core.Application.Interface
{
    public interface IBookRepository
    {
        Book create(Book book);
        Book Update(Book book);
        Book Get(string id);
        Book GetByName(string Title);
        ICollection<Book> GetAll();
        
        bool Delete(string id);
    }
}