using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;

namespace LibrarySystemAdo.net.Core.Application.Interface.Service
{
    public interface ILibraryDirectorService
    {
        Baseresponse< LibrarydirectorDto> Create(CreateRequestLibrarydirectorDto model);
        Baseresponse<LibrarydirectorDto> Get( string staffNumber);
        Baseresponse<UpdatedirectorRequestModel> Update(UpdatedirectorRequestModel model);

    }
}