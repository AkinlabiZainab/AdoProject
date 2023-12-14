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
    public class ProfileAdo :IProfileRepository
    {
        // StartUp StartUp = new StartUp();
        public string connectionStrings = "server = localhost; user = root; database = LibrarySystem22; password = Zbugatti123?";
        public MySqlConnection Connection() => new MySqlConnection(connectionStrings);
        public Profile Create(Profile profile)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var query = $"Insert into Profile(Id, Firstname, Lastname, PhoneNumber, Address, UserId) values('{profile.Id}', '{profile.FirstName}','{profile.LastName}', '{profile.PhoneNumber}', '{profile.Address}', '{profile.UserId}');";
                var command = new MySqlCommand(query, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return profile;
                }
                return null;


            }
        }

        public Profile Get(string id)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from Book where Id = @id;", connect);
                command.Parameters.AddWithValue("@id", id);
                var row = command.ExecuteReader();
                Profile profile= new();
                while (row.Read())
                {
                    profile.Id = Convert.ToString(row[0]);
                    profile.FirstName = Convert.ToString(row[1]);
                profile.LastName = Convert.ToString(row[2]);
                    profile.PhoneNumber = Convert.ToString(row[3]);
                    profile.Address = Convert.ToString(row[4]);
                    profile.UserId= Convert.ToString(row[3]);
                }
                return profile;
            }
        }

        public ICollection<Profile> GetAll()
        {
            List<Profile> profile = new List<Profile>();
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"Select * From Profile;", connect);
                var row = command.ExecuteReader();
                while (row.Read())
                {
                    Profile profile1= new Profile();
                    profile1.Id = Convert.ToString(row[0]);
                    profile1.FirstName = Convert.ToString(row[1]);
                    profile1.LastName = Convert.ToString(row[2]);
                    profile1.PhoneNumber = Convert.ToString(row[3]);
                    profile1.Address = Convert.ToString(row[4]);
                    profile1.UserId = Convert.ToString(row[3]);

                    profile.Add(profile1);
                }

            }
            return profile;
        }

        public Profile GetByEmail(string email)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from Profile where Email= @email;", connect);
                command.Parameters.AddWithValue("@email", email);
                var row = command.ExecuteReader();
                Profile profile = new();
                while (row.Read())
                {
                    profile.Id = Convert.ToString(row[0]);
                    profile.FirstName = Convert.ToString(row[1]);
                    profile.LastName = Convert.ToString(row[2]);
                    profile.PhoneNumber = Convert.ToString(row[3]);
                    profile.Address = Convert.ToString(row[4]);
                    profile.UserId = Convert.ToString(row[3]);
                }
                return profile;
            }
        }

    }
}