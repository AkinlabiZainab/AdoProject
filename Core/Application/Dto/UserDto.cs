using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain.Enum;

namespace Desktop.LibrarySystemAdo.net.Core.Application.Dto
{
    public class UserDto
    {
        public string Id {get; set;}
        public string UserName { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string RoleName { get; set; } = default!;
        public string RoleDescription { get; set; }= default!;
  
    }

    public class LoginRequestModel
    {
        public string UserName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
    }

    public class LoginResponseModel
    {
        
        public string FullName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
    }
    
}