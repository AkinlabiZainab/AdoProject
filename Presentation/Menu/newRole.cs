using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;
using LibrarySystemAdo.net.Core.Application.Implementation;
using LibrarySystemAdo.net.Core.Application.Interface.Service;

namespace LibrarySystemAdo.net.Presentation.Menu
{
    public class newRole
    {
            IRoleService _roleService =  new RoleService();
        
            public void RoleMenu()
            {
            var lp = true;
                while(lp) 
                {
                    Console.WriteLine("enter 1 to create a role\nenter 2 to view all roles\nenter 4 to delete a role|n enter 5 to return to previous menu");
                    string opt = Console.ReadLine();
                    if (opt == "1")
                    {
                        CreateRoleMenu();
                        RoleMenu();

                    }
                    else if (opt == "2")
                    {
                        AllRoles();
                        RoleMenu();

                    }

                    else if (opt == "4")
                    {
                        DeleteRole();
                        RoleMenu();

                    }
                    else if (opt == "5")
                    {
                        lp = false;
                    }
                    else
                    {
                        Console.WriteLine("wrong input");
                        //newMain.MainMenu();
                    }
                }

                
            }

            public void CreateRoleMenu()
            {
                Console.WriteLine("Enter your role name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your role description");
                string description = Console.ReadLine();
                var roleCreated = new CreateRoleRequestModel
                {
                    Description = description,
                    Name = name,
                };
                // Console.WriteLine("nn");
                var le = _roleService.Create(roleCreated);
            Console.WriteLine(le.Message);

            }
            public void AllRoles()
            {
                var _roles =_roleService.GetAll();
                foreach (var item in _roles)
                {
                    Console.WriteLine($" ID: {item.Id}      NAME:{item.Name}    DESCRIPTION: {  item.Description}");
                }
            }
            
            public void DeleteRole()
            {
                Console.WriteLine("Enter the name of the role you want to delete");
                string name = Console.ReadLine();
                _roleService.Delete(name);
                Console.WriteLine("role successfully deleted");

            }
        }
            
}