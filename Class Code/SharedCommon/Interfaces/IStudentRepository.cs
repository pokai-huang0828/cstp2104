using SharedCommon.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCommon.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetStudents(Filter filter);

        public void Add(Student student);

        public void Update(Student student);

        public void Delete(string studentID);

        Student Get(string studentID);
    }
}
