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
    public class newBook
    {
            IBookService book = new BookService();
            public void BookMenu()
            {
            bool xyz = true;
                while (xyz)
                {
                Console.WriteLine("Enter 1 to CreateBook\nEnter 2 to View All Books\nEnter 3 to Delete a book\n Enter 4 to return to the mainMenu");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    CreateBook();
                    BookMenu();



                }
                else if (opt == 2)
                {
                    ViewAvailableBooks();
                    BookMenu();
                    //newMain.MainMenu();

                }
               else if (opt == 3)
                {
                    DeleteBook();
                    BookMenu();

                }
                else if (opt == 4)
                {
                    xyz = false;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    //newMain.MainMenu();
                }
            }
               
            }

            public void CreateBook()
            {
                Console.WriteLine("enter the Author name");
                string Author = Console.ReadLine();
                Console.WriteLine("Enter the book Title");
                string Title = Console.ReadLine();
                Console.WriteLine("Enter the book Version");
                string Version = Console.ReadLine();
                Console.WriteLine("Enter numbers of Copies");
                int Copies = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose a genre");
                Console.WriteLine("1.Fiction ");
                Console.WriteLine("2.Biography ");
                Console.WriteLine("3. Romance ");
                Console.WriteLine("4.   Religious");
                int genre = int.Parse(Console.ReadLine());
                var BookCreated = new CreateBookRegisterModel
                {
                    Author = Author,
                    Copies = Copies,
                    Genre = (Genre)genre,
                    Title = Title,
                    Version = Version,
                };
                book.RegisterBook(BookCreated);
                Console.WriteLine("Book has been successfully created");
            }

            public void ViewAvailableBooks()
            {
                var _booking = book.GetAll();
                foreach (var item in _booking)
                {
                    Console.WriteLine($" ID: {item.Id}      TiTle : {item.Title}   Author: {item.Author}   Genre : {item.Genre}    Version: {item.Version}  IsDeleted : {item.IsDeleted}    Copies: {item.Copies}    IsAvailable: {item.IsAvailable}"  );
                }
            }

            public void DeleteBook()
            {
                Console.WriteLine("enter book id");
                string id = Console.ReadLine();
                book.Delete(id);
                Console.WriteLine("Book has been successfully deleted");

            }
            public void ReturnBook()
            {
                Console.WriteLine("enter your ptofile id");
                string id = Console.ReadLine();
                Console.WriteLine("enter the name of the book you want to return");
                string bookName = Console.ReadLine();
                var booked = new UpdatBookRequestModel
                {
                    Title = bookName,
                    isReturned = true,
                    DateReturned = DateTime.Now,
                    
                };
                book.UpdateBook(booked);
            }
        

            
        } 
}
