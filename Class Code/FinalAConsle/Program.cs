using DataAccessLayer;
using SharedCommon.Entities;
using System;

namespace FinalAConsle
{
    public class Program
    {
        static DBConfig dbconfig = new DBConfig();
        static StudentRepository studentRepository = new StudentRepository(dbconfig);
        static CourseRepository courseRepository = new CourseRepository(dbconfig);

        static void Main(string[] args)
        {
            PrerequisiteCoursesForStudent("000437894");
            //NonPrerequisiteCoursesForStudent("000435811");
            //GetAllStudent();
            //GetAllCoursesInfo();
            //GetStudentUnCompletedCourses("000429977");
        }

        public static void GetAllStudent()
        {
            var students = studentRepository.GetAllStudents();

            foreach (var student in students)
            {
                Console.WriteLine(
                    "Program: {0} \n" +
                    "StudentID: {1} \n" +
                    "Student Name: {2} \n" +
                    "Registrant Time (YYYY-MM): {3} \n"
                    , student.ProgramID, student.StudentID, student.StudentFullName, student.RegistrantYearMonth);
            }
        }

        public static void GetAllCoursesInfo()
        {
            var courses = courseRepository.GetCourses();

            foreach (var course in courses)
            {
                Console.WriteLine(
                    "CourseID: {0} \n" +
                    "Course Name: {1} \n" +
                    "Description: {2} \n" +
                    "Program: {3} \n" +
                    "Has Prerequisite: {4} \n" +
                    "Required: {5} \n" +
                    "Credits: {6} \n"
                    , course.CourseID, course.CourseName, course.CourseDescription, course.ProgramID, course.HasPrerequisite, course.isRequired, course.Credits);
            }
        }

        public static void GetStudentCompletedCourses(string studentID)
        {
            var courses = courseRepository.GetStudentCompletedCourses(studentID);

            foreach (var studentcourses in courses)
            {
                Console.WriteLine(
                    "CourseID: {0} \n" +
                    "Grade: {1} \n" +
                    "PassTerm: {2} \n"
                    , studentcourses.CourseID, studentcourses.Grade, studentcourses.PassTerm);
            }
        }

        public static void GetStudentUnCompletedCourses(string studentID)
        {
            var courses = courseRepository.GetStudentUnCompletedCourses(studentID);

            foreach (var unpassCourse in courses)
            {
                Console.WriteLine(
                    "CourseID: {0} \n" +
                    "Course Name: {1} \n" +
                    "Has Prerequisite: {2} \n" +
                    "Is Required: {3} \n" +
                    "Credits: {4} \n"
                    , unpassCourse.CourseID, unpassCourse.CourseName, unpassCourse.HasPrerequisite, unpassCourse.isRequired, unpassCourse.Credits);
            }
        }

        public static void NonPrerequisiteCoursesForStudent(string studentID)
        {
            var courses = courseRepository.NonPrerequisiteCoursesForStudent(studentID);

            foreach (var nonPrerequisiteCourses in courses)
            {
                Console.WriteLine(
                    "CourseID: {0} \n" +
                    "Course Name: {1} \n" +
                    "CourseDescription: {2} \n" +
                    "Credits: {3} \n", 
                    nonPrerequisiteCourses.CourseID, 
                    nonPrerequisiteCourses.CourseName, 
                    nonPrerequisiteCourses.CourseDescription, 
                    nonPrerequisiteCourses.Credits);
                /*
                var nonPrerequisite = new Course()
                {
                    CourseID = reader.GetString(0),
                    CourseName = reader.GetString(1),
                    CourseDescription = reader.GetString(2),
                    Credits = reader.GetInt32(3),
                };
                */
            }
        }


        public static void PrerequisiteCoursesForStudent(string studentID)
        {
            var courses = courseRepository.PrerequisiteCoursesForStudent(studentID);

            foreach (var prerequisiteCourses in courses)
            {

                Console.WriteLine(
                    "CourseID: {0} \n" +
                    "PrerequisiteID: {1} \n" +
                    "Description: {2} \n",
                    prerequisiteCourses.CourseID,
                    prerequisiteCourses.PrerequisiteID,
                    prerequisiteCourses.Description);
               
            }
        }

    }
}
