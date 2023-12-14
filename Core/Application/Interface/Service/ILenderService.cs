using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;

namespace LibrarySystemAdo.net.Core.Application.Interface.Service
{
    public interface ILenderService
    {
         Baseresponse<LenderDto> RegisterLender(LenderDto model);
        Baseresponse<LenderDto> Get(string Id);
        List<LenderDto> GetAll();
    }
}