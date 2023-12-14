using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;
using LibrarySystemAdo.net.Core.Application.Interface;
using LibrarySystemAdo.net.Core.Application.Interface.Service;
using LibrarySystemAdo.net.Infrastructure.Repositories;

namespace LibrarySystemAdo.net.Core.Application.Implementation
{
    public class UserService:  IUserService
    {
        IUserRepository _userRepository = new UserAdo();
        public Baseresponse<UserDto> Login(LoginRequestModel moddel)
        {
            var user = _userRepository.GetByEmail(moddel.Email);
            if (user != null && user.Password == moddel.Password)
            {
                return new Baseresponse<UserDto>
                {
                    Status = true,
                    Data = new UserDto
                    {
                        Password = user.Password,
                        Email = user.Email,
                        RoleName = user.RoleName,

                    }
                };
                
            }
            return new Baseresponse<UserDto>
            {
                Status = false,
                Message = "User not registered, invalid cridentials",
                Data = null,
            };

        }
    }
}