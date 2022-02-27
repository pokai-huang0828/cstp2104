using SharedCommon.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCommon.Interfaces
{
    public interface ICourseRepository
    {
        List<Course> GetCourses();
        List<Course> GetCourses(string CourseIDFilter);
    }
}
