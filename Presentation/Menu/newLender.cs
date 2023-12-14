using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net.Core.Application.Dto;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;
using LibrarySystemAdo.net.Core.Application.Implementation;
using LibrarySystemAdo.net.Core.Application.Interface.Service;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibrarySystemAdo.net.Presentation.Menu
{
    public class newLender
    {
            Lender lending = new Lender();
            ILenderService lend = new LenderService();
            IBookService bookService = new BookService();
            newBook book = new newBook();
            Book booking = new Book();
            //MainMenu newmin = new MainMenu();

        public void LenderMenu()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter 1 if you want to lend a book\n Enter 2 to return to the mainMenu");
                int opt = int.Parse(Console.ReadLine());
                if(opt == 1)
                {
                    book.ViewAvailableBooks();
                    CreateBorrowedBook();
                   
                    BorrwoAgain();

                }
                else if(opt ==2)
                {
                    check = false;
                }
            }
             
            // Console.WriteLine("Enter 1 if you want to lend a book\n Enter 2 to return to the mainMenu");
            // int opt = int.Parse(Console.ReadLine());
            // bool check = true;
            // while (check)
            // {
            //      if (opt == 1)
            //     {
            //         book.ViewAvailableBooks();
            //         CreateBorrowedBook();

            //          BorrwoAgain();
            //          break;


            //     }
            //     else if (opt == 2)
            //     {
            //         check = false;
            //        // break;

            //     }
            //     if (opt == 3)
            //     {
            //         //book.ReturnBook();
            //     }

            // }

        }
        public void CreateBorrowedBook()
        {

            Console.WriteLine("enter your profile id");
            string profileId = Console.ReadLine();
            Console.WriteLine("select a book, enter book Id ");
            string id = Console.ReadLine();
            var b = new LenderDto
            {
                ProfileID = profileId,
                BookId = id,
                DateBorrowed = DateTime.Now,
            };
            var le = lend.RegisterLender(b);
        
            Console.WriteLine("books should be returned after  5 working days");

            Console.WriteLine($"Here is your reference number {le.Data.RefNumber}");
            Console.WriteLine("Happy Reading");
           
           


            // var books = new HashSet<BookDto>();
            //Console.WriteLine("How many books are you lending");
            //int ans = int.Parse(Console.ReadLine());

            ////for (int i = 0; i <= ans-1 ; i++)
            ////{

            //var booking = bookService.Get(id);
            //        if (booking.Status == true)
            //        {

            //}


            //Console.WriteLine(booking.Message);




        }
        public void BorrwoAgain()
        {
            bool b = true;
            while(b)
            {
                Console.WriteLine("Do you want to lend another book, enter yes or no");
                string ans = Console.ReadLine();
                if (ans == "yes")
                {
                    CreateBorrowedBook();
                }
                if (ans == "no")
                {
                    b= false;
                    break;
                }

            }

            
        }
        public void GetAllLender()
        {
            var b = lend.GetAll();
            foreach (var item in b)
            {
                Console.WriteLine($" ID : {item.Id}  ProfileId: {item.ProfileID}    RefNumber: {item.RefNumber}     BookId: {item.Booking.Id}       DateBorrowed: {item.DateBorrowed}");
            }



        }

    }
                

        
}
