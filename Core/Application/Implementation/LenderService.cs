using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;
using Google.Protobuf.Collections;
using LibrarySystemAdo.net.Core.Application.Interface;
using LibrarySystemAdo.net.Core.Application.Interface.Service;
using LibrarySystemAdo.net.Infrastructure.Repositories;

namespace LibrarySystemAdo.net.Core.Application.Implementation
{
    public class LenderService : ILenderService
    {
        IBookRepository books = new BookAdo();
        IProfileRepository profiles = new ProfileAdo();
        IUserRepository used = new UserAdo();
        IRoleRepository roleRepository = new RoleAdo();
        ILenderRepository lender = new LenderAdo();
        public Baseresponse<LenderDto> Get(string Id)
        {
            var exists = lender.Get(Id);
            if (exists == null)
            {
                return new Baseresponse<LenderDto>
                {
                    Status = false,
                    Message = $"there is no lender with {Id} regiatered here ",

                };
            }
            
            return new Baseresponse<LenderDto>
            {
                Status = true,
                Message = "Successful",
                Data = new LenderDto
                {
                    Id = exists.Id,
                    // Book = exists.BooksT.ToList(),
                    //Book = exists.BooksT.Select(a => new BookDto
                    //{

                    //    Id = a.Id
                    //}).ToList(),
                    DateBorrowed = DateTime.Now,
                    RefNumber = exists.RefNumber,
                    ProfileID = exists.ProfileID,
                    BookId = exists.BookId,





                }
            };

        }
        

        public List<LenderDto> GetAll()
        {
            var _lend = lender.GetAll();
            List<LenderDto> _list = new List<LenderDto>();
            foreach (var item in _lend)
            {
                if (item.IsDeleted == false)
                {
                    var b = new LenderDto
                    {
                        Id = item.Id,
                        //Book = item.BooksT.Select(a => new BookDto
                        //{

                        //    Id = a.Id
                        //}).ToList(),
                        //Book = (ICollection<BookDto>) item.BooksT ,
                        RefNumber = item.RefNumber,
                        ProfileID = item.ProfileID,
                        BookId = item.BookId,
                        DateBorrowed = DateTime.Now,

                    };
                    _list.Add(b);

                }

            }
            return _list;

        }
        private string GenerateRefNumber()
        {
            return $"CLH/2023/{new Random().Next(100, 999)}";
        }

        public Baseresponse<LenderDto> RegisterLender(LenderDto model)
        {
            var exists =  lender.Get(model.Id);
            if (exists != null)
            {
                return new Baseresponse<LenderDto>
                {
                    Status = false,
                    Message = $"lender already exist" ,

                };
            }
            var role = roleRepository.GetByName("Lender");
            var p = profiles.Get(model.Id);
           var bookCollected = books.Get(model.BookId);
           if(bookCollected == null)
           {
                return new Baseresponse<LenderDto>
                {
                    Status = false,
                    Message= "book not found"
                };
           }
           
            Lender let = new Lender()
            {

                RefNumber = GenerateRefNumber(),
                DateBorrowed = DateTime.Now,
                ProfileID = p.Id,
               BookId = model.BookId,

            };
            bookCollected.Copies -= 1;
            lender.Create(let);
            

            

            return new Baseresponse<LenderDto>
            {
                Message = "successful",
                Status = true,
                Data = new LenderDto
                {
                    DateBorrowed = DateTime.Now,
                    isReturned = false,
                    DateReturned = DateTime.Now,
                    RefNumber = let.RefNumber,
                    //Book = let.BooksT.Select(a=> new BookDto
                    //{
                    //    Id = a.Id,
                    //}).ToList(),
                    ProfileID = let.ProfileID,
                    BookId = let.BookId,

                    
                }
            
            };
        }

    }
}