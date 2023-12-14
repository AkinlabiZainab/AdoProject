using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;

namespace LibrarySystemAdo.net.Core.Application.Interface.Service
{
    public interface IRoleService
    {
        Baseresponse<RoleDto> Create(CreateRoleRequestModel model);
        Baseresponse<RoleDto> GetByName(string Name);
        //List<Baseresponse<RoleDto>> GetAll();
        List<RoleDto> GetAll();
        bool Delete(string name);
    }
}