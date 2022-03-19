using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCommon.Entities
{
    public class Course
    {
        //CREATE TABLE Course (
        //      CourseID VARCHAR(10) not null PRIMARY KEY,
        //      CourseName VARCHAR(25),
        //      CourseDescription VARCHAR(100),
        //      ProgramID VARCHAR(10),
        //      HasPrerequisite BIT,
        //      isRequired BIT,
        //      Credits Int,
        //      foreign key (ProgramID) References [dbo].[Program](ProgramID));

        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string ProgramID { get; set; }
        public bool HasPrerequisite { get; set; }
        public bool isRequired { get; set; }
        public int Credits { get; set; }
    }
}
