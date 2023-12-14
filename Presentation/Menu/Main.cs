using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;
using Desktop.LibrarySystemAdo.net.Core.Domain.Enum;
using LibrarySystemAdo.net.Core.Application.Implementation;
using LibrarySystemAdo.net.Core.Application.Interface.Service;

namespace LibrarySystemAdo.net.Presentation.Menu
{
    public class Main
    {
            newBook book = new newBook();
            IUserService userService = new UserService();
            IProfileService newP = new ProfileService();
            ILenderService lend = new LenderService();
            newLibraryDirector lib = new newLibraryDirector();
            newLender led = new newLender();

            ILibraryDirectorService dir = new LibraryDirectorService();
            newProfile prof = new newProfile();
            public void MainMenu()
            {
                Console.WriteLine("Welcome to folajo Library");
                Console.WriteLine("Enter 1 to REGISTER\n Enter 2 to LOGIN");
                int opt = int.Parse(Console.ReadLine());
                if(opt == 1)
                {
                    Register();
                    MainMenu();
                }
                else if(opt == 2)
                {
                Login();
                    MainMenu();
                }
                else{
                Console.WriteLine("invalid input");
                MainMenu();
                }

            }
            public void Register()
            {
                Console.WriteLine("Enter your first name");
                string firstname = Console.ReadLine();
                Console.WriteLine("Enter your last name");
                string lastname = Console.ReadLine();
                Console.WriteLine("Enter your phonenumber");
                string phonenumber = Console.ReadLine();
                //Console.WriteLine("1- male, 2 - female");
                //int gender = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter your Email");
                string email = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                var p = new CreateProfileRequestModel
                {
                    Password = password,
                    Address = address,
                    Email = email,
                    FirstName = firstname,
                    //Gender = (Gender)gender,
                    PhoneNumber = phonenumber,
                    LastName = lastname,



                };
                var x = newP.Create(p);

                Console.WriteLine($"profile created successfully\n Here is your profileid {x.Data.Id}");
            }


            public void Login()
            {
                Console.WriteLine("enter your Email");
                string email = Console.ReadLine();
                Console.WriteLine("enter your Password");
                string password = Console.ReadLine();
                // if(password )
                // {
                //     Console.WriteLine("pasword must not exceed 4 ");
                // }
                var b = new LoginRequestModel
                {
                    Email = email,
                    Password = password,

                };

                var response = userService.Login(b);


                if (!response.Status)
                {
                    Console.WriteLine(response.Message);

                }
                else
                {
                    if (response.Data.RoleName == "Director")
                    {
                        lib.LibararyDirectorMenu();
                    }
                   
                    else if (response.Status == true)
                    {

                        led.LenderMenu();
                    }

                }

            }

        }

    
}