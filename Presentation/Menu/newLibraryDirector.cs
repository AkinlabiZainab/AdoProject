using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystemAdo.net.Core.Application.Implementation;
using LibrarySystemAdo.net.Core.Application.Interface.Service;

namespace LibrarySystemAdo.net.Presentation.Menu
{
    public class newLibraryDirector
    {
            newRole _role2 = new newRole();       
            newBook _book = new();
            newProfile _profile = new();
        
            newLender lend = new();
            ILenderService lending = new LenderService();
            public void LibararyDirectorMenu()
            {
                Console.WriteLine("Enter 1 to view BookMenu\nEnter 3 to view ProfileMenu\nEnter 4 to view RoleMenu\nEnter 6 to view Lenders Menu\nEnter 0 to LogOut");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    _book.BookMenu();
                    LibararyDirectorMenu();
                }
                
                else if (opt == 3)
                {
                    _profile.ProfileMenu();
                    LibararyDirectorMenu();
            }
                else if (opt == 4)
                {
                    
                    _role2.RoleMenu();
                     LibararyDirectorMenu();
            }
                
                else if (opt == 6)
                {
                    lend.GetAllLender();
                   LibararyDirectorMenu();
            }
                else if (opt == 0)
                {
                // _staff.StaffMenu();
                }

                else
                {
                    Console.WriteLine("wrong input");
                    LibararyDirectorMenu();
                    
                    
                }
            }
        }
            
}