using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Entities;
using Exercise.Data;

namespace Exercise.Business
{
    public class StudentB
    {
        StudentD objStudent;

        public StudentB()
        {
            objStudent = new StudentD();
        }

        public List<Student> GetStudent()
        {
            return objStudent.GetStudent();
        }

        public Student GetDetails(int id)
        {
            return objStudent.GetDetails(id);
        }

        public bool Create(Student student)
        {
            return objStudent.Create(student);
        }

        public bool Edit(Student student)
        {
            return objStudent.Edit(student);
        }

        public bool Delete(int id)
        {
            return objStudent.Delete(id);
        }

        public void Dispose()
        {
            objStudent.Dispose();
        }
    }
}
