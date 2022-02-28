using DataAccessLayer;
using System;

namespace FinalAConsle
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCoursesInfo();
        }

        private static void GetCoursesInfo()
        {
            var dbConfig = new DBConfig();
            var courseRepository = new CourseRepository(dbConfig);

            var courses = courseRepository.GetCourses();

            foreach (var course in courses)
            {
                Console.WriteLine(
                    "CourseID: {0} \n" +
                    "Course Name: {1} \n" +
                    "Description: {2} \n" +
                    "Has Prerequisite: {3} \n", course.CourseID, course.CourseName, course.CourseDescription, course.HasPrerequisite);
            }
        }
    }
}
