using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;

namespace LibrarySystemAdo.net.Core.Application.Interface.Service
{
    public interface IProfileService
    {
        Baseresponse<ProfileDto> Create(CreateProfileRequestModel model);
        Baseresponse<ProfileDto> Get(string id);
        Baseresponse<UpdateProfileRequestModdel> Update(UpdateProfileRequestModdel model);
        List<ProfileDto> GetAll();
        bool Delete (string id);
    }
}