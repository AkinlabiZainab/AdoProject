using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desktop.LibrarySystemAdo.net;
using Desktop.LibrarySystemAdo.net.Core.Domain;
using LibrarySystemAdo.net.Core.Application.Interface;
using MySql.Data.MySqlClient;

namespace LibrarySystemAdo.net.Infrastructure.Repositories
{
    public class RoleAdo :IRoleRepository
    {
        // StartUp StartUp = new StartUp();
        public string connectionStrings = "server = localhost; user = root; database = LibrarySystem22; password = Zbugatti123?";
        public MySqlConnection Connection() => new MySqlConnection(connectionStrings);
        public Role Create(Role role)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var query = $"Insert into Role (Id, Name, Description) values('{role.Id}', '{role.Name}','{role.Description}');";
                var command = new MySqlCommand(query, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return role;
                }
                return null;


            }
        }

               

        public bool Delete(string name)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var query = $"DELETE FROM Role WHERE Name = @name;";
                var command = new MySqlCommand(query, connect);
                command.Parameters.AddWithValue("@name", name);
                var rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Role Get(string id)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from Role where Id = @id;", connect);
                command.Parameters.AddWithValue("@id", id);
                var row = command.ExecuteReader();
                Role role = null;
                while (row.Read())
                {
                    role = new Role();  
                    role.Id = Convert.ToString(row[0]);
                    role.Name= Convert.ToString(row[1]);
                    role.Description = Convert.ToString(row[2]);
                   // role.UserId = Convert.ToString(row[3]);
                
                }
                return role;
            }
        }

        public ICollection<Role> GetAll()
        {
            List<Role> role = new List<Role>();
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"Select * From Role;", connect);
                var row = command.ExecuteReader();
                while (row.Read())
                {
                Role roles = new Role();
                    roles.Id = Convert.ToString(row[0]);
                    roles.Name = Convert.ToString(row[1]);
                    roles.Description = Convert.ToString(row[2]);
                   // roles.UserId = Convert.ToString(row[3]);


                    role.Add(roles);
                }

            }
            return role;
        }

        public Role GetByName(string Name)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from Role where Name = @Name;", connect);
                command.Parameters.AddWithValue("@Name", Name);
                var row = command.ExecuteReader();
                Role role = null;
                while (row.Read())
                {
                    role = new Role();
                    role.Id = Convert.ToString(row[0]);
                    role.Name = Convert.ToString(row[1]);
                    role.Description = Convert.ToString(row[2]);
                   // role.UserId = Convert.ToString(row[3]);

                }
                return role;
            }
        }
    }
}

       