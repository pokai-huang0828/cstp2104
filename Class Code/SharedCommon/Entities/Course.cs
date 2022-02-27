using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCommon.Entities
{
    public class Course
    {
        //CREATE TABLE course(CourseID VARCHAR(10), CourseName VARCHAR(25), CourseDescription VARCHAR(100), HasPrerequisite BIT)

        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public bool HasPrerequisite { get; set; }
    }
}
