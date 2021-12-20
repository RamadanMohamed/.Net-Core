using lab6mvccore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.services
{
    public class studantdb : IStudentOp
    {
        private ITIModel _db;

        public studantdb(ITIModel db)
        {
            _db = db;
        }
        
        public Student addstudent(Student std)
        {
            _db.students.Add(std);
            _db.SaveChanges();
            return std;
        }

        public Student DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudent()
        {
            return _db.students.ToList<Student>();
        }

        public Student getstudent(int Id)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(Student std)
        {
            throw new NotImplementedException();
        }
    }
}
