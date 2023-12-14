using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;
using LibrarySystemAdo.net.Core.Application.Interface;
using LibrarySystemAdo.net.Core.Application.Interface.Service;
using LibrarySystemAdo.net.Infrastructure.Repositories;

namespace LibrarySystemAdo.net.Core.Application.Implementation
{
    public class BookService : IBookService
    {
        IBookRepository _books = new BookAdo();
        public bool Delete(string Id)
        {
        
            
            var exists = _books.Get(Id);

            if(exists  != null)
            {
                exists.IsDeleted = true;
                _books.Delete(Id);
                return true;
                //Console.WriteLine("book successfully deleted");

            }
            Console.WriteLine($"book {Id} is not available");
            return false;
        }

        public Baseresponse<BookDto> Get(string Id)
        {
            var exists = _books.Get(Id);
            if (exists == null)
            {
                return new Baseresponse<BookDto>
                {
                    Status = false,
                    Message = $"there is no book with {Id} regiatered here ",

                };
            }
            return new Baseresponse<BookDto>
            {
                Status = true,
                Message = "Successful",
                Data = new BookDto
                {
                    
                    Author = exists.Author,
                    Copies = exists.Copies ,
                    Id = exists.Id,
                    Genre = exists .Genre,
                    Title = exists.Title,
                    Version = exists.Version,

                }

            };
        }

        public List<BookDto> GetAll()
        {
            var books = _books.GetAll();
       
            List<BookDto> _list = new List<BookDto>();
            
            foreach (var item in books)
            {
                if(item.IsDeleted == false && item.Copies > 0)
                {
                    var b = new BookDto
                    {
                        Id = item.Id,
                        Author = item.Author,
                        Copies = item.Copies,
                        Genre = item.Genre,
                        Title = item.Title,
                        Version = item.Version,
                        IsDeleted = item.IsDeleted,


                    };
                    _list.Add(b);   

                }

            }
        // _booking.ReadFromFile();
            return _list;

        }


        public Baseresponse<BookDto> RegisterBook(CreateBookRegisterModel model)
        {
            var exists = _books.Get(model.Title );
            var exist2 = _books.Get(model.Author);
            if(exists != null)
            {
                return new Baseresponse<BookDto>
                {
                    Status = false,
                    Message = "Book is already registered in the system, you can specify the author ",
                };
            }
            if(exist2 != null)
            {
                return new Baseresponse<BookDto>
                {
                    Status = false,
                    Message = $"Book in {model.Author} is registerd in the system,please check your upload properly",
                };
            }
            Book book = new Book
            {
            
                Author = model.Author,
                Copies = model.Copies,
                Genre = model.Genre,
                Title = model.Title,
                Version = model.Version,
            
            };
            _books.create(book);
            return new Baseresponse<BookDto>
            {
                Status = true,
                Message = "successful",
                Data = new BookDto
                {
                    Author = book.Author,
                    Title = book.Title,
                    Copies = book.Copies,
                    Version = book.Version,
                    Genre = book.Genre,
                    Id = book.Id,
                    
                }
                
            };
        
        }

        public Baseresponse<UpdatBookRequestModel> UpdateBook(UpdatBookRequestModel model)
        {
            var exists = _books.GetByName(model.Title);
            if(exists == null)
            {
                return new Baseresponse<UpdatBookRequestModel>
                {
                    Status = false,
                    Message = "book not found",
                };
            }
            Book boo = new Book
            {
            Copies = exists.Copies + model.AddCopies,

            };

            _books.Update(boo);
            return new Baseresponse<UpdatBookRequestModel>
            {
                Status = true,
                Message = "Successful",
                Data = new UpdatBookRequestModel
                {
                    AddCopies = model.AddCopies,
                    Copies = boo.Copies,
                    isReturned = true,
                    DateReturned = DateTime.Now,
                    Title = model.Title,
                    
                    
                }
            };
            
        }
        //public void AddMoreCopies(string id)
        //{
        //    var add = _books.Get(id);
        //    if(add != null)
        //    {
        //        var added = add.Copies + add.AddCopies;
        //        Console.WriteLine(added);
        //    }

        //}
        public void GetBookCount()
        {
            
        }
        
    }
    
}