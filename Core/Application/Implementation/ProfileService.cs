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
    public class ProfileService : IProfileService
    {
            IUserRepository usiers = new UserAdo();
            IProfileRepository newProfs = new ProfileAdo();
            public Baseresponse<ProfileDto> Create(CreateProfileRequestModel model)
            {    
                var exists = usiers.GetByEmail(model.Email);
                if (exists != null)
                {
                    return new Baseresponse<ProfileDto>
                    {
                        Status = false,
                        Data = null,
                        Message = $"profile  exist already",

                    };
                }
                User us = new User()
                {
                    Email = model.Email,
                    
                    Password = model.Password,
                };
                usiers.Create(us);

                Profile prof = new Profile()
                {
                    Address = model.Address,
                    LastName = model.LastName,
                    Image = model.Image,
                    PhoneNumber = model.PhoneNumber,
                    FirstName = model.FirstName,
                    Gender = model.Gender,
                    UserId = us.Id,


                };
                newProfs.Create(prof);
                
                return new Baseresponse<ProfileDto>
                {
                    Status = true,
                    Data = new ProfileDto
                    {
                        Id = prof.Id,
                        Address = prof.Address,
                        // Email = us.Email,
                        Gender = prof.Gender,
                        Image = prof.Image,
                        LastName = prof.LastName,
                    // Password = us.Password,
                        PhoneNumber = prof.PhoneNumber,
                        FirstName = prof.FirstName,
                        UserId = prof.UserId,
                    }

                };
            }
            public bool Delete(string id)
            {
                var exists = newProfs.Get(id);

                if (exists != null)
                {
                    exists.IsDeleted = true;
                    return true;

                }
                Console.WriteLine($"book {id} is not available");
                return false;
            }



            public Baseresponse<ProfileDto> Get(string id)
            {
                var exists = newProfs.Get(id);
                if (exists == null)
                {
                    return new Baseresponse<ProfileDto>
                    {
                        Status = false,
                        Message = $"there is no book with {id} regiatered here ",

                    };
                }
                return new Baseresponse<ProfileDto>
                {
                    Status = true,
                    Message = "Successful",
                    Data = new ProfileDto
                    {

                        FirstName = exists.FirstName,
                        Address = exists.Address,
                        UserId = exists.UserId,
                    // UserName = exists.user.UserName,
                    // Email = exists.user.Email,
                        PhoneNumber = exists.PhoneNumber,
                        //Password = exists.user.Password,
                        Gender = exists.Gender,
                        LastName = exists.LastName,
                        Image = exists.Image

                    }

                };
            
            }

            public List<ProfileDto> GetAll()
            {
                var profiling = newProfs.GetAll();
                List<ProfileDto> _list = new List<ProfileDto>();
                foreach (var item in profiling)
                {
                    if (item.IsDeleted == false)
                    {
                        var b = new ProfileDto
                        {
                        FirstName= item.FirstName,
                        Address= item.Address,
                        // Email  = item.user.Email,
                        Gender = item.Gender,
                        LastName= item.LastName,
                        // Password = item.user.Password,
                        PhoneNumber = item.PhoneNumber,
                            //UserName = item.user.UserName,
                        Image = item.Image,
                        UserId = item.UserId,


                        };
                        _list.Add(b);

                    }

                }
                // _booking.ReadFromFile();
                return _list;

            }

                public Baseresponse<UpdateProfileRequestModdel> Update(UpdateProfileRequestModdel model)
                {
                    var exists = newProfs.Get(model.id);
                    if (exists == null)
                    {
                        return new Baseresponse<UpdateProfileRequestModdel>
                        {
                            Status = false,
                            Message = "profile not found",
                        };
                    }
                    Profile po = new Profile
                    {
                    PhoneNumber = model.PhoneNumber,
                    LastName = model.LastName,
                    FirstName = model.FirstName,
                    Image = model.Image,
                    Address = model.Address,
                    Gender = model.Gender,


                    };

                // newProfs.Update(po);
                    return new Baseresponse<UpdateProfileRequestModdel>
                    {
                        Status = true,
                        Message = "Successful",
                        Data = new UpdateProfileRequestModdel
                        {
                        
                            Gender = po.Gender,
                            Image = po.Image,
                            LastName = po.LastName,
                            FirstName = po.FirstName,
                            PhoneNumber = po.PhoneNumber,
                        
                            Address = po.Address,

                        }
                    };

                }
        }
    
}