using SharedCommon.Entities;
using SharedCommon.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IDBConfig dbConfig;
        public StudentRepository(IDBConfig dbConfig)
        {
            this.dbConfig = dbConfig;
        }

        public List<Student> GetAllStudents()
        {
            string sqlQuery = $"SELECT * FROM STUDENT";
            var students = new List<Student>();

            try
            {
                using (var connection = new SqlConnection(dbConfig.GetConnectionString()))
                {

                    using (var command = new SqlCommand(sqlQuery))
                    {
                        command.Connection = connection;
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var student = new Student()
                                {
                                    StudentID = reader.GetString(0),
                                    StudentFullName = reader.GetString(1),
                                    ProgramID = reader.GetString(2),
                                    RegistrantYearMonth = reader.GetString(3)
                                };
                                students.Add(student);
                            }
                        }
                    }
                }
                return students;
            }
            catch (Exception ErrorSQL)
            {
                Console.WriteLine("Exception: " + ErrorSQL.Message);
            }
            return null;          
        }

        public List<Student> GetStudents(Filter filter)
        {
            var students = new List<Student>();
            using (var connection = new SqlConnection(dbConfig.GetConnectionString()))
            {
                string sqlQuery = $"SELECT * FROM STUDENT WHERE ID = '{filter.ID}' OR Name = '{filter.Name}'";
                using (var command = new SqlCommand(sqlQuery))
                {
                    command.Connection = connection;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student = new Student() { 
                                StudentID = reader.GetString(0), 
                                StudentFullName = reader.GetString(1), 
                                ProgramID = reader.GetString(2), 
                                RegistrantYearMonth = reader.GetString(3) 
                            };
                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }

        public Student Get(string studentID)
        {
            using (var connection = new SqlConnection(dbConfig.GetConnectionString()))
            {
                string sqlQuery = $"SELECT * FROM STUDENT WHERE ID = '{studentID}'";
                using (var command = new SqlCommand(sqlQuery))
                {
                    command.Connection = connection;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        {
                            var student = new Student() { 
                                StudentID = reader.GetString(0), 
                                StudentFullName = reader.GetString(1), 
                                ProgramID = reader.GetString(2), 
                                RegistrantYearMonth = reader.GetString(3) 
                            };
                            return student;
                        }
                    }
                }
            }
        }

        public void Add(Student student)
        {
            using (var connection = new SqlConnection(dbConfig.GetConnectionString()))
            {
                string sqlQuery = $"INSERT INTO STUDENT VALUES ({student.StudentID}, {student.StudentFullName}, {student.ProgramID}";
                using (var command = new SqlCommand(sqlQuery))
                {
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(string studentID)
        {
            using (var connection = new SqlConnection(dbConfig.GetConnectionString()))
            {
                string v = $"DELETE FROM STUDENT WHERE ID = '{studentID}'";
                string sqlQuery = v;
                using (var command = new SqlCommand(sqlQuery))
                {
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Student student)
        {
            using (var connection = new SqlConnection(dbConfig.GetConnectionString()))
            {
                string sqlQuery = $"UPDATE STUDENT SET Name = '{student.StudentFullName}', ProgramID = '{student.ProgramID}' WHERE ID = '{student.StudentID}'";
                using (var command = new SqlCommand(sqlQuery))
                {
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
