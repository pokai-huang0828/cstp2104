using SharedCommon.Entities;
using SharedCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetStudents()
        {
            return new List<Student>();
        }
    }
}
