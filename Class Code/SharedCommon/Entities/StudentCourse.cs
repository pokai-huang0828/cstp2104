using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCommon.Entities
{
    public class StudentCourse
    {
        //CREATE TABLE StudentCourse (
        //      StudentID VARCHAR(10),
        //      CourseID VARCHAR(10),
        //      isCompleted BIT,
        //      Grade VARCHAR(10),
        //      PassTerm VARCHAR(10),
        //      foreign key (StudentID) References [dbo].[Student](StudentID),
        //      foreign key (CourseID) References [dbo].[Course](CourseID));

        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public bool isCompleted { get; set; }
        public string Grade { get; set; }
        public string PassTerm { get; set; }

    }
}
