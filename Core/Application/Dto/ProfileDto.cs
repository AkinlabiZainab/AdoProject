using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;
using Desktop.LibrarySystemAdo.net.Core.Domain.Enum;

namespace Desktop.LibrarySystemAdo.net.Core.Application.Dto
{
    public class ProfileDto
    {
        public string Id {get; set;} 
        public string UserId { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; }= default!;
        public string Image { get; set; }= default!;
        public string PhoneNumber { get; set; } = default!;
        public Gender Gender { get; set; }
        public string Address { get; set; }= default!;
        public string Email { get; set; }= default!;
        public string Password { get; set; } = default!;
        public string UserName { get; set; }= default!;
        public User user { get; set; } = default!;

    }
    public class CreateProfileRequestModel
    {
        // public string Id { get; set;} = default!; 
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; }= default!;
        public string Image { get; set; }= default!;
        public string PhoneNumber { get; set; } = default!;
        public Gender Gender { get; set; }
        public string Address { get; set; }= default!;
        public string Email { get; set; }= default!;
        public string Password { get; set; } = default!;
        public string UserName { get; set; }= default!;
        public User user { get; set; } = default!;
        
    }
    public class UpdateProfileRequestModdel
    {
    public string id {get; set;} 
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; }= default!;
        public string Image { get; set; }= default!;
        public string PhoneNumber { get; set; } = default!;
        public Gender Gender { get; set; }
        public string Address { get; set; }= default!;
        public string Email { get; set; }= default!;
        public string Password { get; set; } = default!;
        public string UserName { get; set; }= default!;
        
    }
    
}