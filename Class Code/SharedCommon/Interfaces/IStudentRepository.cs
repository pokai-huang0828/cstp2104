using SharedCommon.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCommon.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> Get(Filter filter);

        void Add(Student student);

        void Update(Student student);

        Student Get(string studentID);

        void Delete(string studentID);
    }
}
