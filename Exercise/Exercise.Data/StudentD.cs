using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Entities;
using System.Data.Entity;

namespace Exercise.Data
{

    public class StudentD
    {
        ExerciseDataContainer db;

        public StudentD()
        {
            db = new ExerciseDataContainer();
        }

        public List<Student> GetStudent()
        {
            return db.Student.ToList();
        }

        public Student GetDetails(int id)
        {
            return db.Student.Find(id);
        }

        public bool Create(Student student)
        {
            try
            {
                db.Student.Add(student);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(Student student)
        {
            try
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var group = db.Student.Find(id);
                db.Student.Remove(group);
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public void Dispose()
        {
            db.Dispose();        
        }
    }
}
