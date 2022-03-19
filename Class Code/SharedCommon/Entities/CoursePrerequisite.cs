using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCommon.Entities
{
    public class CoursePrerequisite
    {
        //CREATE TABLE CoursePrerequisite(
        //      CourseID VARCHAR(10),
        //      PrerequisiteID VARCHAR(10),
        //      Description VARCHAR(255),
        //      PrerequisiteState BIT,
        //      foreign key(CourseID) References[dbo].[Course] (CourseID),
        //      foreign key(PrerequisiteID) References[dbo].[Course] (CourseID));

        public string CourseID { get; set; }
        public string PrerequisiteID { get; set; }
        public string Description { get; set; }
        public bool PrerequisiteState { get; set; }

    }
}
