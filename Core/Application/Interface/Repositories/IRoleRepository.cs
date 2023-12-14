using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain;

namespace LibrarySystemAdo.net.Core.Application.Interface
{
    public interface IRoleRepository
    {
        Role Create (Role role);
        Role Get (string id);
        Role GetByName(string Name);
        ICollection<Role> GetAll();
        bool Delete(string name);
        
       

    }
}