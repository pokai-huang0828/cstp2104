using SharedCommon.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using SharedCommon.Interfaces;

namespace BusinessLogic
{
     public class StudentRegisterationManager
    {
        private readonly IStudentRepository studentRepository;

        public StudentRegisterationManager(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public List<Student> GetRegisteredStudents()
        {
            var students = this.studentRepository.GetStudents();

            return students;
        }
    }
}
