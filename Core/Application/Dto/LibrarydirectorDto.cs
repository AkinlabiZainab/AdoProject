using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;
using Desktop.LibrarySystemAdo.net.Core.Domain.Enum;

namespace Desktop.LibrarySystemAdo.net.Core.Application.Dto
{
    public class LibrarydirectorDto
    {
        public string Id { get; set; }
        public string profileId { get; set; }
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Image { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public Gender Gender { get; set; }
        public string Address { get; set; } = default!;
        public string StaffNumber { get; set; } = default!;
        public string RoleName { get; set; }
        public Role Role { get; set; }
    }
    public class CreateRequestLibrarydirectorDto
    {
        public string RoleName { get; set; }
        public string Email { get; set; }= default!;
        public string Password { get; set; } = default!;
        public string UserName { get; set; }= default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; }= default!;
        public string Image { get; set; }= default!;
        public string PhoneNumber { get; set; } = default!;
        public Gender Gender { get; set; }
        public User user { get; set; } 
        public string Address { get; set; }= default!;
        public string  staffNumber { get; set; }
        
    }
    public class UpdatedirectorRequestModel
    {
        public string id {get; set;} 
         public string Email { get; set; }= default!;
        public string Password { get; set; } = default!;
        public string UserName { get; set; }= default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; }= default!;
        public string Image { get; set; }= default!;
        public string PhoneNumber { get; set; } = default!;
        public Gender Gender { get; set; }
        public string Address { get; set; }= default!;
        public Profile profile { get; set; }
           
    }
}
