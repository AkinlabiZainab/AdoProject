using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Desktop.LibrarySystemAdo.net
{
    public class StartUp
    {
        public StartUp()
        {
            CreateSchema();
            CreateBookTable();
            CreateLenderTable();
            CreateLibraryDirectorTable();
            CreateProfileTable();
            CreateRoleTable();
            CreateUserTable();

        }
        public string connectionStrings = "server = localhost; user = root; database = LibrarySystem22; password = Zbugatti123?";
        public MySqlConnection Connection() => new MySqlConnection(connectionStrings);



        public void CreateSchema()
        {
            string connectionStrings = "server = localhost; user = root; ; password = Zbugatti123?";
            using (var connection = new MySqlConnection(connectionStrings))
            {
                connection.Open();
                var querry = "create schema if not exists LibrarySystem22";
                var command = new MySqlCommand(querry, connection);
                int row = command.ExecuteNonQuery();
                Console.WriteLine(row > 0 ? "schema created successfully" : "not created");
            }


        }

        public void CreateTable(string tableQuerry)
        {
            using (var connection = Connection())
            {
                connection.Open();
                var command = new MySqlCommand(tableQuerry, connection);
                int row = command.ExecuteNonQuery();
                Console.WriteLine(row != -1 ? "table created successfully" : "table not created");
            }
        }

        public void CreateBookTable()
        {
            var querry = "create table if not exists Book" + 
                "(Id varchar(50) not null unique," +
                "Title varchar(50) ," +
                "Author varchar(50) , " +
                "Version varchar(50) ," +
                "Copies int," +
                "IsDeleted int, " +
                 "DeletedBy varchar(50)," +
                
                "primary key(Id))" ;
            CreateTable(querry);
            
        }
        public void CreateLenderTable()
        {
            var querry = "create table if not exists Lender" +
                "(Id varchar(50) not null unique," +
                "ProfileId varchar(50) ," +
                "RefNumber varchar(50) ," +
                "BookId varchar(50)," +
                "DateBorrowed DateTime ," +
                "IsDeleted int, " +
                 "DeletedBy varchar(50)," +
                
                "primary key(Id))";
            CreateTable(querry);

        }

        public void CreateLibraryDirectorTable()
        {
            var querry = "create table if not exists LibraryDirector"+
                "(Id varchar (50) not null unique,"+
                "StaffNumber varchar(50) unique,"+
                "ProfileId varchar(50),"+
                "IsDeleted int, " +
                 "DeletedBy varchar(50)," +
               
                "primary key(Id))";
            CreateTable(querry);
        

        }

        public void CreateProfileTable()
        {
            var querry = "create table if not exists Profile" +
                "(Id varchar (50) not null unique," +
                "Firstname varchar(50)," +
                "Lastname varchar(50)," +
                "PhoneNumber varchar(50)," +
                "Address varchar(50)," +
                "UserId varchar(50)," +
                "IsDeleted int, " +
                "DeletedBy varchar(50),"+
              
                "primary key(Id))";
            CreateTable(querry);
          
        }
        public void CreateRoleTable()
        {
            var querry = "create table if not exists Role" +
                "(Id varchar(50) not null unique," +
                "Name varchar(50)," +
                "Description varchar(50)," +
                "IsDeleted int, " +
                 "DeletedBy varchar(50)," +
                
                "primary key(Id))";
        
            CreateTable(querry);
        }
        public void CreateUserTable()
        {
            var querry = "create table if not exists USer" +
                "(Id varchar (50) not null unique," +
                "Email varchar(50) unique," +
                "Password varchar(50), " +
                "Rolename varchar(50)," +
                "IsDeleted int, " +
                 "DeletedBy varchar(50)," +
               
                "primary key(Id))";
            CreateTable(querry);
            
        }
    }
    
}