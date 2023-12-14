using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;

namespace LibrarySystemAdo.net.Core.Application.Interface.Service
{
    public interface IUserService
    {
        Baseresponse<UserDto> Login(LoginRequestModel moddel);
        /* Baseresponse<UserDto> Get(string id);

        List<UserDto> GetUsers();*/
    }
}