using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinAppLib.DBMS
{
    public class AdoNetExample
    {
        public SqliteConnection OpenConnection()
        {
            SqliteConnection connection = new SqliteConnection();
            return connection;
        }

        public void CreateAndAddRows()
        {
            var connection = this.OpenConnection();
            var command = connection.CreateCommand();
            command.CommandText = "CREATE TABLE students (name VARCHAR(50), email VARCHAR(50), address VARCHAR(100), id INTEGER)";
            connection.Open();
            command.ExecuteNonQuery();

            var insertCommand = connection.CreateCommand();
            insertCommand.CommandText = "INSERT INTO students (name, email, address, id) VALUES (@name, @email, @address, @id)";
            insertCommand.Parameters.AddWithValue("@name", "PoKai Huang");
            insertCommand.Parameters.AddWithValue("@email", "pokai@gmail.com");
            insertCommand.Parameters.AddWithValue("@address", "3137 W 43rd Ave, BC");
            insertCommand.Parameters.AddWithValue("@id", "1001");
            int result = insertCommand.ExecuteNonQuery();

            insertCommand.Parameters.Clear();
            insertCommand.Parameters.AddWithValue("@name", "Elaine Lee");
            insertCommand.Parameters.AddWithValue("@email", "elaine@gmail.com");
            insertCommand.Parameters.AddWithValue("@address", " 4867 W 40th Ave, BC");
            insertCommand.Parameters.AddWithValue("@id", "1002");
            result = insertCommand.ExecuteNonQuery();



            var queryCommand = connection.CreateCommand();
            queryCommand.CommandText = "SELECT * FROM students";
            var reader = queryCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("========= Students ==========");
                Console.WriteLine("Student Name:    " + reader[0]);
                Console.WriteLine("Student Email:   " + reader[1]);
                Console.WriteLine("Student Address: " + reader[2]);
                Console.WriteLine("Student ID:      " + reader[3]);
            }

            connection.Close();
        }
    }
}
