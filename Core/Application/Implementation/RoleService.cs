using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;
using Desktop.LibrarySystemAdo.net.Core.Domain;
using LibrarySystemAdo.net.Core.Application.Interface;
using LibrarySystemAdo.net.Core.Application.Interface.Service;
using LibrarySystemAdo.net.Infrastructure.Repositories;

namespace LibrarySystemAdo.net.Core.Application.Implementation
{
    public class RoleService : IRoleService
    {
        IRoleRepository _roleinter =new  RoleAdo();
  
        public Baseresponse<RoleDto> Create(CreateRoleRequestModel model)
        {
        var exists = _roleinter.GetByName(model.Name);
        if(exists != null)
        {
            return new Baseresponse<RoleDto>
            {
                
                Message =$"role {model.Name} already exists",
                
            };
            
        }
        Role role = new Role
        {
            Name = model.Name,
            Description = model.Description,
           

        };
        _roleinter.Create(role);
        
        return new Baseresponse<RoleDto>
        {
            Status = true,
            Message = "successful",
            Data = new RoleDto
            {
                Description = role.Description,
                Id = role.Id,
                Name = role.Name,
                // });
                
            }
        };
        }

        public bool Delete(string name)
        {
            var exists = _roleinter.GetByName(name);
            if(exists == null)
            {
                Console.WriteLine($" role {name} dosent exists");
            }
            
            var b= exists.IsDeleted = true;
            _roleinter.Delete(name);
            return b;
        
            
        }

        public List<RoleDto> GetAll()
        {
        var roles = _roleinter.GetAll();
        List<RoleDto> listOfRole = new List<RoleDto>();
        foreach (var item in roles)
        {
                if(item.IsDeleted == false)
                {
                    var a = new RoleDto
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Description = item.Description

                    };
                    listOfRole.Add(a);
                }
        }
        
        return listOfRole;
        }

        public Baseresponse<RoleDto> GetByName(string Name)
        {
            var exists = _roleinter.GetByName(Name);
            if(exists == null)
            {
                Console.WriteLine($" role {Name} dosent exists");
            }
            return  new Baseresponse<RoleDto>{
                Status = true,
                Message = "sucessful",
                Data = new RoleDto
                {
                    Id = exists.Id,
                    Name = exists.Name,
                    Description = exists.Description,
                }

            };

        }

        
    }

    
}