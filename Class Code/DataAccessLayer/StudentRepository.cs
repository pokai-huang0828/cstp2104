using SharedCommon.Entities;
using SharedCommon.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(string studentID)
        {
            throw new NotImplementedException();
        }

        public Student Get(string studentID)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get(Filter filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
