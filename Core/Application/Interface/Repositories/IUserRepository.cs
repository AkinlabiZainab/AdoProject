using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;

namespace LibrarySystemAdo.net.Core.Application.Interface
{
    public interface IUserRepository
    {
        User Create(User user);
        User Get(string id);
        User GetByEmail(string email);
       // User Login( string email, string password);
        ICollection<User> GetAll();
        
    }
}