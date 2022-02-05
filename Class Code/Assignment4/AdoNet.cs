using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class AdoNet
    {
        public SqliteConnection OpenConnection()
        {
            SqliteConnection connection = new SqliteConnection();
            return connection;
        }


        public void CreateTables()
        {

// --------- Add Program Table ----------

            var connection = this.OpenConnection();
            var AddProgramTable = connection.CreateCommand();
            AddProgramTable.CommandText = "CREATE TABLE Program(Id int PRIMARY KEY, ProgramName VARCHAR(100), Description VARCHAR(255));";

            try
            {
                connection.Open();
                AddProgramTable.ExecuteNonQuery();
                Console.WriteLine("Connect successful!\n");
            }
            catch (SqliteException ex)
            {
                Console.WriteLine("Connect fail...\n");
                Console.WriteLine(ex);
            }

// --------- Add Program Data ------------

            var insertProgramCommand = connection.CreateCommand();
            insertProgramCommand.CommandText = "INSERT INTO Program(Id, ProgramName, Description) VALUES ( @Id, @ProgramName, @Description);";

            insertProgramCommand.Parameters.AddWithValue("@Id", 1552);
            insertProgramCommand.Parameters.AddWithValue("@ProgramName", "Computer Systems Technology");
            insertProgramCommand.Parameters.AddWithValue("@Description", "Build skills in programming, design, mobile apps, and security while launching your career developing software and solving computer-related issues for businesses, governments, or institutions.");

            insertProgramCommand.ExecuteNonQuery();

            insertProgramCommand.Parameters.Clear();
            insertProgramCommand.Parameters.AddWithValue("@Id", 1137);
            insertProgramCommand.Parameters.AddWithValue("@ProgramName", "VR/AR Design and Development");
            insertProgramCommand.Parameters.AddWithValue("@Description", "Create the tools of tomorrow by learning to develop and produce human-centred virtual reality (VR) or augmented reality (AR) experiences using Oculus Rift, Oculus Quest, HTC Vive, and Unreal and Unity engines.");

            insertProgramCommand.ExecuteNonQuery();

// ---------- Show Program Data ------------

            var queryProgramCommand = connection.CreateCommand();
            queryProgramCommand.CommandText = "SELECT * FROM Program";
            var programReader = queryProgramCommand.ExecuteReader();
            while (programReader.Read())
            {
                Console.WriteLine("\n========= Program ==========\n");
                Console.WriteLine("Program ID:   " + programReader[0]);
                Console.WriteLine("Program Name: " + programReader[1]);
                Console.WriteLine("Description:  " + programReader[2] + "\n");
            }

//---------- Add Student Table --------------------

            var AddStudentTable = connection.CreateCommand();
            AddStudentTable.CommandText = "CREATE TABLE Student(Id INT PRIMARY KEY, Name VARCHAR(100), StreetAddress VARCHAR(100), City VARCHAR(100), Province VARCHAR(100), Country VARCHAR(100), PostalCode VARCHAR(100), Email VARCHAR(100), PhoneNumber VARCHAR(100), ProgramId INT, FOREIGN Key(ProgramId) REFERENCES Program(Id));";
            AddStudentTable.ExecuteNonQuery();

//---------- Add Student Data --------------------

            var insertStudentCommand = connection.CreateCommand();
            insertStudentCommand.CommandText = "INSERT INTO Student(Id, Name, StreetAddress, City, Province, Country, PostalCode, Email, PhoneNumber, ProgramId) VALUES (@Id, @Name, @StreetAddress, @City, @Province, @Country, @PostalCode, @Email, @PhoneNumber, @ProgramId);";

            
            insertStudentCommand.Parameters.AddWithValue("@Id", 429977);
            insertStudentCommand.Parameters.AddWithValue("@Name", "Pokai Huang");
            insertStudentCommand.Parameters.AddWithValue("@StreetAddress", "3137 W 43rd Ave");
            insertStudentCommand.Parameters.AddWithValue("@City", "Vancouver");
            insertStudentCommand.Parameters.AddWithValue("@Province", "BC");
            insertStudentCommand.Parameters.AddWithValue("@Country", "Canada");
            insertStudentCommand.Parameters.AddWithValue("@PostalCode", "V6N 3J4");
            insertStudentCommand.Parameters.AddWithValue("@Email", "kenny@gmail.com");
            insertStudentCommand.Parameters.AddWithValue("@PhoneNumber", "+1(778)251-8867");
            insertStudentCommand.Parameters.AddWithValue("@ProgramId", 1552);
            insertStudentCommand.ExecuteNonQuery();

            insertStudentCommand.Parameters.Clear();
            insertStudentCommand.Parameters.AddWithValue("@Id", 458698);
            insertStudentCommand.Parameters.AddWithValue("@Name", "Elaine Lee");
            insertStudentCommand.Parameters.AddWithValue("@StreetAddress", "5743 Vine St");
            insertStudentCommand.Parameters.AddWithValue("@City", "Vancouver");
            insertStudentCommand.Parameters.AddWithValue("@Province", "BC");
            insertStudentCommand.Parameters.AddWithValue("@Country", "Canada");
            insertStudentCommand.Parameters.AddWithValue("@PostalCode", "V6M 1Z8");
            insertStudentCommand.Parameters.AddWithValue("@Email", "elaine@gmail.com");
            insertStudentCommand.Parameters.AddWithValue("@PhoneNumber", "+1(778)357-5234");
            insertStudentCommand.Parameters.AddWithValue("@ProgramId", 1137);
            insertStudentCommand.ExecuteNonQuery();

// ---------- Show Student Data ------------

            var queryCommand = connection.CreateCommand();
            queryCommand.CommandText = "SELECT * FROM Student";
            var reader = queryCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("\n========= Students ==========\n");
                Console.WriteLine("Student ID:    " + reader[0]);
                Console.WriteLine("Student Name:  " + reader[1]);
                Console.WriteLine("StreetAddress: " + reader[2]);
                Console.WriteLine("City:          " + reader[3]);
                Console.WriteLine("Province:      " + reader[4]);
                Console.WriteLine("Country:       " + reader[5]);
                Console.WriteLine("PostalCode:    " + reader[6]);
                Console.WriteLine("Email:         " + reader[7]);
                Console.WriteLine("PhoneNumber:   " + reader[8]);
                Console.WriteLine("ProgramId:     " + reader[9] + "\n");
            }

// -------- Add Course Table ------------

            var AddCourseTable = connection.CreateCommand();
            AddCourseTable.CommandText = "CREATE TABLE Course(Id int PRIMARY KEY, CourseName VARCHAR(100), Description VARCHAR(255), Credit INT);";
            AddCourseTable.ExecuteNonQuery();

 // -------- Add Course Data -------------

            var insertCourseCommand = connection.CreateCommand();
            insertCourseCommand.CommandText = "INSERT INTO Course( Id, CourseName, Description, Credit) VALUES ( @Id, @CourseName, @Description, @Credit);";

            insertCourseCommand.Parameters.AddWithValue("@Id", 2104);
            insertCourseCommand.Parameters.AddWithValue("@CourseName", "Windows Interactive App Prog");
            insertCourseCommand.Parameters.AddWithValue("@Description", "Students will program with C# using .NET framework, XAML (eXtensible Application Markup Language), and Windows Forms to build industry standard GUI-rich applications with interesting and sophisticated back-ends.");
            insertCourseCommand.Parameters.AddWithValue("@Credit", "3");
            insertCourseCommand.ExecuteNonQuery();

            insertCourseCommand.Parameters.Clear();
            insertCourseCommand.Parameters.AddWithValue("@Id", 1304);
            insertCourseCommand.Parameters.AddWithValue("@CourseName", "User Experience and Interface Design");
            insertCourseCommand.Parameters.AddWithValue("@Description", "This course will give students a strong foundational understanding of the user interface (UI) and user experience (UX) design principles designers need to create intuitive and effective websites and apps.");
            insertCourseCommand.Parameters.AddWithValue("@Credit", "3");
            insertCourseCommand.ExecuteNonQuery();

// ---------- Show Course Data ------------

            var queryCourseCommand = connection.CreateCommand();
            queryCourseCommand.CommandText = "SELECT * FROM Course";
            var Coursereader = queryCourseCommand.ExecuteReader();
            while (Coursereader.Read())
            {
                Console.WriteLine("\n========= Course ==========\n");
                Console.WriteLine("Course ID:   " + Coursereader[0]);
                Console.WriteLine("Course Name: " + Coursereader[1]);
                Console.WriteLine("Description: " + Coursereader[2] + "\n");
            }

// ---------- Add ProgramCourse Table ----------

            var AddProgramCourseTable = connection.CreateCommand();
            AddProgramCourseTable.CommandText = "CREATE TABLE ProgramCourse(ProgramId int, CourseId Int, Required boolEAN, FOREIGN Key(ProgramId) REFERENCES Program(Id), FOREIGN Key(CourseId) REFERENCES Course(Id));";
            AddProgramCourseTable.ExecuteNonQuery();

// ---------- Add ProgramCourse Data ------------

            var insertProgramCourseCommand = connection.CreateCommand();
            insertProgramCourseCommand.CommandText = "INSERT INTO ProgramCourse(ProgramId, CourseId, Required) VALUES (@ProgramId, @CourseId, @Required);";

            insertProgramCourseCommand.Parameters.AddWithValue("@ProgramId", 1552);
            insertProgramCourseCommand.Parameters.AddWithValue("@CourseId", 2104);
            insertProgramCourseCommand.Parameters.AddWithValue("@Required", "True");
            insertProgramCourseCommand.ExecuteNonQuery();

            insertProgramCourseCommand.Parameters.Clear();
            insertProgramCourseCommand.Parameters.AddWithValue("@ProgramId", 1552);
            insertProgramCourseCommand.Parameters.AddWithValue("@CourseId", 1304);
            insertProgramCourseCommand.Parameters.AddWithValue("@Required", "True");
            insertProgramCourseCommand.ExecuteNonQuery();

            insertProgramCourseCommand.Parameters.Clear();
            insertProgramCourseCommand.Parameters.AddWithValue("@ProgramId", 1137);
            insertProgramCourseCommand.Parameters.AddWithValue("@CourseId", 2104);
            insertProgramCourseCommand.Parameters.AddWithValue("@Required", "False");
            insertProgramCourseCommand.ExecuteNonQuery();

            insertProgramCourseCommand.Parameters.Clear();
            insertProgramCourseCommand.Parameters.AddWithValue("@ProgramId", 1137);
            insertProgramCourseCommand.Parameters.AddWithValue("@CourseId", 1304);
            insertProgramCourseCommand.Parameters.AddWithValue("@Required", "True");
            insertProgramCourseCommand.ExecuteNonQuery();

// ---------- Show ProgramCourse Data ------------

            var queryProgramCourseCommand = connection.CreateCommand();
            queryProgramCourseCommand.CommandText = "SELECT * FROM ProgramCourse";
            var ProgramCoursereader = queryProgramCourseCommand.ExecuteReader();
            while (ProgramCoursereader.Read())
            {
                Console.WriteLine("\n========= Program Course ==========\n");
                Console.WriteLine("Program ID: " + ProgramCoursereader[0]);
                Console.WriteLine("Course ID:  " + ProgramCoursereader[1]);
                Console.WriteLine("Required:   " + ProgramCoursereader[2] + "\n");
            }

            connection.Close();
        }  
    }
}
