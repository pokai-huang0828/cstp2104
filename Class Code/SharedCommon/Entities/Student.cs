using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCommon.Entities
{
    public class Student
    {
        //Create Table Student (
        //      StudentID VARCHAR(10) not null Primary key,
        //      StudentFullName VARCHAR(100),
        //      ProgramID VARCHAR(10),
        //      RegistrantYearMonth VARCHAR(10),
        //      foreign key (ProgramID) References [dbo].[Program](ProgramID));

        public string StudentID { get; set; }
        public string StudentFullName { get; set; }
        public string ProgramID { get; set; }
        public string RegistrantYearMonth { get; set; }

    }
}
