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
    public class LenderAdo :ILenderRepository
    {
        // StartUp StartUp = new StartUp();
        public string connectionStrings = "server = localhost; user = root; database = LibrarySystem22; password = Zbugatti123?";
        public MySqlConnection Connection() => new MySqlConnection(connectionStrings);

        public Lender Create(Lender lender)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var DateBorrowed = lender.DateBorrowed.ToString("yyyy-MM-dd HH:mm:ss");
                var query = $"Insert into Lender(Id,ProfileId,RefNumber, BookId, DateBorrowed) values('{lender.Id}', '{lender.ProfileID}','{lender.RefNumber}','{lender.BookId}' ,'{DateBorrowed}');";
                var command = new MySqlCommand(query, connect);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return lender;
                }
                return null;


            }
        }

        public bool Delete(string id)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var query = $"DELETE FROM Lender WHERE ID = @id;";
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

        public Lender Get(string id)
        {
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"select * from Lender where ID = @id;", connect);
                command.Parameters.AddWithValue("@id", id);
                var row = command.ExecuteReader();
                Lender lend = null;
                while (row.Read())
                {
                    lend.Id = Convert.ToString(row[0]);
                    lend.ProfileID = Convert.ToString(row[1]);
                    lend.RefNumber = Convert.ToString(row[2]);
                    lend.BookId = Convert.ToString(row[3]);
                    lend.DateBorrowed = Convert.ToDateTime(row[4]);

                    
                }
                return lend;
            }

        }

        public ICollection<Lender> GetAll()
        {
            List<Lender> lends = new List<Lender>();
            using (var connect = Connection())
            {
                connect.Open();
                var command = new MySqlCommand($"Select * From Lender;", connect);
                var row = command.ExecuteReader();
                while (row.Read())
                {
                    Lender lend  = new Lender();

                    lend.Id = Convert.ToString(row[0]);
                    lend.ProfileID = Convert.ToString(row[1]);
                    lend.RefNumber = Convert.ToString(row[2]);
                    lend.BookId = Convert.ToString(row[3]);
                    lend.DateBorrowed = Convert.ToDateTime(row[4]);

                    lends.Add(lend);
                }

            }
            return lends;

        }

        public Lender Update(Lender lender)
        {
            throw new NotImplementedException();
        }
    }
}