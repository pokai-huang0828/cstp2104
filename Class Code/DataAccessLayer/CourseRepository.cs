﻿using Microsoft.Data.SqlClient;
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
                string sqlQuery = 
                    "SELECT * FROM COURSE";
                using (var command = new SqlCommand(sqlQuery))
                {
                    command.Connection = connection;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var course = new Course() { 
                                CourseID = reader.GetString(0), 
                                CourseName = reader.GetString(1),
                                CourseDescription = reader.GetString(2),
                                ProgramID = reader.GetString(3), 
                                HasPrerequisite = reader.GetBoolean(4),
                                isRequired = reader.GetBoolean(5),
                                Credits = reader.GetInt32(6),
                            };
                            courses.Add(course);
                        }
                    }
                }
            }

            return courses;
        }

        public List<StudentCourse> GetStudentCompletedCourses(string studentID)
        {
            var studentcourses = new List<StudentCourse>();
            using (var connection = new SqlConnection(dbConfig.GetConnectionString()))
            {
                string query = 
                    $"SELECT StudentCourse.CourseID, " +
                    $"StudentCourse.Grade, " +
                    $"StudentCourse.PassTerm FROM StudentCourse StudentCourse " +
                    $"INNER JOIN Course Course ON Course.CourseID = StudentCourse.CourseID " +
                    $"WHERE(StudentID = '{studentID}' AND isCompleted = 'True')";

                using (var command = new SqlCommand(query))
                {
                    command.Connection = connection;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var studentcourse = new StudentCourse() { 
                                CourseID = reader.GetString(0), 
                                Grade = reader.GetSqlValue(1).ToString(),
                                PassTerm = reader.GetString(2) };
                            studentcourses.Add(studentcourse);
                        }
                    }
                }
            }
            return studentcourses;
        }

        public List<Course> GetStudentUnCompletedCourses(string studentID)
        {
            var unpassCourses = new List<Course>();
            using (var connection = new SqlConnection(dbConfig.GetConnectionString()))
            {
                string query =
                    $"SELECT StudentCourse.CourseID, " +
                    $"Course.CourseName, " +
                    $"Course.HasPrerequisite, " +
                    $"Course.isRequired, " +
                    $"Course.Credits FROM StudentCourse StudentCourse " +
                    $"INNER JOIN Course Course ON Course.CourseID = StudentCourse.CourseID " +
                    $"WHERE(StudentID = '{studentID}' AND isCompleted = 'False')";

                using (var command = new SqlCommand(query))
                {
                    command.Connection = connection;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var unpassCourse = new Course()
                            {
                                CourseID = reader.GetString(0),
                                CourseName = reader.GetString(1),
                                HasPrerequisite = reader.GetBoolean(2),
                                isRequired = reader.GetBoolean(3),
                                Credits = reader.GetInt32(4),
                            };
                            unpassCourses.Add(unpassCourse);
                        }
                    }
                }
            }
            return unpassCourses;
        }

        public List<Course> GetCourses(string CourseIDFilter)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCoursesCanTakeForStudent(string studentID)
        {
            throw new NotImplementedException();
        }
    }
}
