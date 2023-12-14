using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;

namespace LibrarySystemAdo.net.Core.Application.Interface
{
    public interface ILenderRepository
    {
        Lender Create(Lender lender);
        Lender Get(string id);
        Lender Update(Lender lender);
        ICollection<Lender> GetAll();
        
        bool Delete(string id);
       
    }
}