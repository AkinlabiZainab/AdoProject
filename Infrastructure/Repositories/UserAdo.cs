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
    public class UserAdo :IUserRepository
    {
        // StartUp StartUp = new();
        public string connectionStrings = "server = localhost; user = root; database = LibrarySystem22; password = Zbugatti123?";
        public MySqlConnection Connection() => new MySqlConnection(connectionStrings);
        public User Create(User user)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var query = $"Insert into User(Id,Email,Password,RoleName) values('{user.Id}', '{user.Email}','{user.Password}', '{user.RoleName}');";
                var command = new MySqlCommand(query, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return user;
                }
                return null;


            }
        }

        public User Get(string id)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from User where Id = @id;", connect);
                command.Parameters.AddWithValue("@id", id);
                var row = command.ExecuteReader();
                User user = new();
                while (row.Read())
                {
                    user.Id = Convert.ToString(row[0]);
                    user.Email = Convert.ToString(row[1]);
                    user.Password = Convert.ToString(row[2]);
                    user.RoleName = Convert.ToString(row[3]);
                
                }
                return user;
            }
        }

        public ICollection<User> GetAll()
        {
            List<User> user1 = new List<User>();
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"Select * From User;", connect);
                var row = command.ExecuteReader();
                while (row.Read())
                {
                    User user = new User();
                    user.Id = Convert.ToString(row[0]);
                    user.Email = Convert.ToString(row[1]);
                    user.Password= Convert.ToString(row[2]);
                    user.RoleName= Convert.ToString(row[3]);


                    user1.Add(user);
                }

            }
            return user1;

        }

        public User GetByEmail(string email)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from User where Email = @email;", connect);
                command.Parameters.AddWithValue("@email", email);
                var row = command.ExecuteReader();
                User user = null;
                while (row.Read())
                {
                    user = new User();
                    user.Id = Convert.ToString(row[0]);
                    user.Email = Convert.ToString(row[1]);
                    user.Password = Convert.ToString(row[2]);
                    user.RoleName = Convert.ToString(row[3]);

                }
                return user;
            }
        }

        //public User Login(string email, string password)
        //{
        //    throw new NotImplementedException();
        //}
    }
}