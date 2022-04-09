using DataAccessLayer;
using SharedCommon.Entities;
using System;

namespace FinalAConsle
{
    public class Program
    {
       

        static void Main(string[] args)
        {
            //AllTest.PrerequisiteCoursesForStudent("000437894");
            AllTest.NonPrerequisiteCoursesForStudent("000435811");
            //AllTest.GetAllStudent();
            //AllTest.GetAllCoursesInfo();
            //AllTest.GetStudentUnCompletedCourses("000429977");
        }

       

    }
}
