using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;

namespace LibrarySystemAdo.net.Core.Application.Interface
{
    public interface ILibraryDirectorRepository
    {
        LibararyDirector Create(LibararyDirector director);
        LibararyDirector Get(string staffNumber);
        LibararyDirector Update(LibararyDirector director);

       
    }
}