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
    public class LibraryDirectorAdo : ILibraryDirectorRepository
    {
        // StartUp StartUp = new StartUp(); 
        public string connectionStrings = "server = localhost; user = root; database = LibrarySystem22; password = Zbugatti123?";
        public MySqlConnection Connection() => new MySqlConnection(connectionStrings);

        public LibararyDirector Create(LibararyDirector director)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var query = $"Insert into Book( (Id, StaffNumber, ProfileId)) values('{director.Id}', '{director.StaffNumber},'{director.ProfileId}');";
                var command = new MySqlCommand(query, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return director;
                }
                return null;


            }
        }

        public LibararyDirector Get(string staffNumber)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from LibraryDirector where Staffnumber = @staffNumber;", connect);
                command.Parameters.AddWithValue("@id", staffNumber);
                var row = command.ExecuteReader();
                LibararyDirector dirs = new();
                while (row.Read())
                {
                    dirs.Id = Convert.ToString(row[0]);
                    dirs.StaffNumber = Convert.ToString(row[1]);
                    dirs.ProfileId = Convert.ToString(row[2]);
                    
                }
                return dirs;
            }
        }

        public LibararyDirector Update(LibararyDirector director)
        {
            throw new NotImplementedException();
        }
    }
}