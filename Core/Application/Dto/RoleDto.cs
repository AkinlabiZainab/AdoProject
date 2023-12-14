using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desktop.LibrarySystemAdo.net.Core.Application.Dto
{
    public class RoleDto
    {
        public string Id {get; set;} 
        public string Name { get; set; } = default!;
        public string Description { get; set; }= default!;
        //public string UserId { get; set;} = default!;

       // public  ICollection<UserDto> UserR = new HashSet<UserDto>();
    }

    public class CreateRoleRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }   
    
}