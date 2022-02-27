using Microsoft.Data.SqlClient;
using SharedCommon.Entities;
using SharedCommon.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IDBConfig dbConfig;
        public CourseRepository(IDBConfig dbConfig)
        {
            this.dbConfig = dbConfig;
        }

        public List<Course> GetCourses()
        {
            var courses = new List<Course>();
            using (var connection = new SqlConnection(dbConfig.GetConnectionString()))
            {
                string sqlQuery = "SELECT CourseID, CourseName FROM COURSE";
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var course = new Course() { CourseID = reader.GetString(0), CourseName = reader.GetString(1) };
                            courses.Add(course);
                        }
                    }
                }
            }

            return courses;
        }

        public List<Course> GetCourses(string CourseIDFilter)
        {
            throw new NotImplementedException();
        }
    }
}
