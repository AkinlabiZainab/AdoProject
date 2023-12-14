using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desktop.LibrarySystemAdo.net.Core.Application.Dto
{
    public class Baseresponse<T>
    {
        public bool Status;
        public string Message =default!;
        public T Data;
        
    }
}