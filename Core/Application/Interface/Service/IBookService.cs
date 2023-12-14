using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;

namespace LibrarySystemAdo.net.Core.Application.Interface.Service
{
    public interface IBookService
    {
        Baseresponse<BookDto> RegisterBook(CreateBookRegisterModel model);
        Baseresponse<BookDto> Get(string Id);
        List<BookDto> GetAll();
        bool Delete(string Id);
        Baseresponse< UpdatBookRequestModel> UpdateBook( UpdatBookRequestModel model);
    }
}