using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;

namespace LibrarySystemAdo.net.Core.Application.Interface
{
    public interface IProfileRepository
    {
        Profile Create (Profile profile);
        //Profile Update (Profile profile);
        Profile Get(String id);
        Profile GetByEmail(string email);
        ICollection<Profile> GetAll();
       
    }
}