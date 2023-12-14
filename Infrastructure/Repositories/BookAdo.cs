using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net;
using Desktop.LibrarySystemAdo.net.Core.Domain.Entities;
using LibrarySystemAdo.net.Core.Application.Interface;
using MySql.Data.MySqlClient;

namespace LibrarySystemAdo.net.Infrastructure.Repositories
{
    public class BookAdo : IBookRepository
    {
        // StartUp StartUp = new StartUp();
        public string connectionStrings = "server = localhost; user = root; database = LibrarySystem22; password = Zbugatti123?";
        public MySqlConnection Connection() => new MySqlConnection(connectionStrings);
        public Book create(Book book)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var query = $"Insert into Book(Id,Title,Author,Version, Copies) values('{book.Id}', '{book.Title}','{book.Author}', '{book.Version}', '{book.Copies}');";
                var command = new MySqlCommand(query, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return  book;
                }
                return null;


            }
        }

        public bool Delete(string id)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var query = $"DELETE FROM Book WHERE Id = @id;";
                var command = new MySqlCommand(query, connect);
                command.Parameters.AddWithValue("@id", id);
                var rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Book Get(string id)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from Book where ID = @id;", connect);
                command.Parameters.AddWithValue("@id", id);
                var row = command.ExecuteReader();
                Book book = null;
                while (row.Read())
                {
                     book = new Book();
                    book.Id = Convert.ToString(row[0]);
                    book.Title = Convert.ToString(row[1]);
                    book.Author = Convert.ToString(row[2]);
                    book.Version = Convert.ToString(row[3]);
                    book.Copies = Convert.ToInt32(row[4]);
                }
                return book;
            }
        }

        public ICollection<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"Select * From Book;", connect);
                var row = command.ExecuteReader();
                while (row.Read())
                {
                    Book book = new Book();
                    book.Id = Convert.ToString(row[0]);
                    book.Title = Convert.ToString(row[1]);
                    book.Author = Convert.ToString(row[2]);
                    book.Version = Convert.ToString(row[3]);
                    book.Copies = Convert.ToInt32(row[4]);

                    books.Add(book);
                
                }
            }
            return books;
        }

        public Book GetByName(string Title)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from Book where Title = @title;", connect);
                command.Parameters.AddWithValue("@title", Title);
                var row = command.ExecuteReader();
                Book book = new();
                while (row.Read())
                {
                    book.Id = Convert.ToString(row[0]);
                    book.Title = Convert.ToString(row[1]);
                    book.Author = Convert.ToString(row[2]);
                    book.Version = Convert.ToString(row[3]);
                    book.Copies = Convert.ToInt32(row[4]);
                }
                return book;
            }
        }

        
        public Book Update(Book book)
        {
            throw new NotImplementedException();
        }

        
    }
}