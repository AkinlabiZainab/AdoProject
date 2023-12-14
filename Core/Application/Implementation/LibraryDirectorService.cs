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
    public class LibraryDirectorService : ILibraryDirectorService
    {
            IRoleRepository roleRepository = new RoleAdo();
            IUserRepository used = new UserAdo();
            IProfileRepository profiles = new ProfileAdo();
            ILibraryDirectorRepository director = new LibraryDirectorAdo();
            public Baseresponse<LibrarydirectorDto> Create(CreateRequestLibrarydirectorDto model)
            {
                var exists = director.Get(model.staffNumber);
                if (exists == null) 
                {
                    return new Baseresponse<LibrarydirectorDto>
                    {
                        Status = false,
                        Message = $"there is no staffnumber with {model.staffNumber} registered here ",

                    };
                }
                //var role = roleRepository.GetByName("Director");
                User us = new User()
                {
                    Email = model.Email,
                    Password = model.Password,
                
                    RoleName = "Director",
                    
                };
                used.Create(us);
                Profile prof = new Profile()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Gender = model.Gender,
                    PhoneNumber = model.PhoneNumber,
                    UserId = us.Id,
                };
                profiles.Create(prof);
            

                LibararyDirector lib = new LibararyDirector()
                {
                    StaffNumber = StaffNumber(),
                    ProfileId = prof.Id,

                };
                director.Create(lib);
                return new Baseresponse<LibrarydirectorDto>
                {
                    Status = true,
                    Message = "Successful",
                    Data = new LibrarydirectorDto
                    {

                        StaffNumber = lib.StaffNumber,
                        profileId = lib.ProfileId,
                        LastName = prof.LastName,
                        FirstName = prof.FirstName,
                        Address = prof.Address,
                        PhoneNumber= prof.PhoneNumber,
                        Gender= prof.Gender,
                        Email = us.Email,
                        Password = us.Password,
                        RoleName = us.RoleName,

                    }

                };
            }
            private string StaffNumber()
            {
                return $"DIR/{new Random().Next(100, 999)}";
            } 

            public Baseresponse<LibrarydirectorDto> Get(string staffNumber)
            {
            var exits = director.Get(staffNumber);
                if(exits == null)
                {
                    return new Baseresponse<LibrarydirectorDto>
                    {
                        Status = false,
                        Message = $"director not registered",

                    };
                }
                return new Baseresponse<LibrarydirectorDto>
                {

                    Status = true,
                    Data = new LibrarydirectorDto
                    {
                        StaffNumber = exits.StaffNumber,
                        Id = exits.Id,
                        profileId = exits.ProfileId,
                    }
                };
            }

            public Baseresponse<UpdatedirectorRequestModel> Update(UpdatedirectorRequestModel model)
            {
                throw new NotImplementedException();
            }

            //public Baseresponse<UpdatedirectorRequestModel> Update(UpdatedirectorRequestModel model)
            //{
            //    var exists = director.Get(model.id);
            //    if (exists == null)
            //    {
            //        return new Baseresponse<UpdatedirectorRequestModel>
            //        {
            //            Status = false,
            //            Message = "director not found",
            //        };
            //    }
            //    LibararyDirector boo = new LibararyDirector()
            //    {
            //        profile = model.profile.(a => new ProfileDto
            //        {
            //            FirstName = model.FirstName,
            //            LastName = model.LastName,
            //            Address = model.Address,
            //            Email = model.Email,
            //            Gender = model.Gender,
            //            Password = model.Password,
            //          PhoneNumber = model.PhoneNumber,

            //        }),


            //    };

            //    _books.Update(boo);
            //    return new Baseresponse<UpdatBookRequestModel>
            //    {
            //        Status = true,
            //        Message = "Successful",
            //        Data = new UpdatBookRequestModel
            //        {
            //            AddCopies = model.AddCopies,
            //            Copies = boo.Copies,


            //        }
            //    };

            //}
    }
    
}