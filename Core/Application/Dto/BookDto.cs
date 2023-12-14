using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Domain.Enum;

namespace Desktop.LibrarySystemAdo.net.Core.Application.Dto
{
    public class BookDto
    {
        public string Id {get; set;} 
        public string Title { get; set; } = default !;
        public string Author { get; set; }
        
        public Genre Genre { get; set; }
        public bool IsAvailable { get; set; }
        public string Version {get; set;}
        public int Copies {get; set;}
        public bool IsDeleted { get; set; }
    }

    public class CreateBookRegisterModel
    {
        
        public string Title { get; set; } = default !;
        public string Author { get; set; }  = default !;
        public Genre Genre { get; set; }
        public string Version {get; set;}
        public int Copies {get; set;}

    }
    public class UpdatBookRequestModel
    {
        public string Title { get; set; } = default!;
        public DateTime DateReturned { get; set; }
        public  bool isReturned { get; set; }
        public string id { get; set; }
        public int  AddCopies {get; set;}
        public int Copies { get; set;}
    // public int TotalCopies { get; set; }
    }

}

   