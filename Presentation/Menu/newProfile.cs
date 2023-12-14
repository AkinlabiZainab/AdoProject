using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystemAdo.net.Core.Application.Implementation;
using LibrarySystemAdo.net.Core.Application.Interface.Service;

namespace LibrarySystemAdo.net.Presentation.Menu
{
    public class newProfile
    {
         IProfileService prof = new ProfileService();
        public void ProfileMenu()
        {
            var b = prof.GetAll();
            foreach (var item in b)
            {
                Console.WriteLine($" ID : {item.Id}     LastName: {item.LastName}    FirstName: {item.FirstName}     Address: {item.Address}       Gender: {item.Gender}      UserId: {item.UserId}            PhoneNumber: {item.PhoneNumber}");
            }
        }


    }

   
}