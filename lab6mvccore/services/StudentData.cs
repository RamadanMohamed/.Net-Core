using lab6mvccore.Controllers;
using lab6mvccore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.services
{
    public class StudentData:IStudentOp 
    {
        List<Student> students = new List<Student>()
        {
            new Student(){ id=1 ,name="ali",Age=12},
             new Student(){ id=2 ,name="saad",Age=15},
              new Student(){ id=3 ,name="mohamed",Age=20},

        };
        public List<Student> GetAllStudent()
        {
            return students;
        }
        public Student getstudent(int Id)
        {
        return students.FirstOrDefault(a => a.id == Id);
           
        }
        public Student addstudent (Student std)
        {
            students.Add(std);
            return (std);
        }

        public Student UpdateStudent(Student std)
        {
            var stud = students.FirstOrDefault(a => a.id == std.id);
            stud.name = std.name;
            stud.Age = std.Age;
            return (stud);
        }

        public Student DeleteStudent(int id)
        {
            var std = students.FirstOrDefault(a => a.id == id);
            students.Remove(std);
            return (std);
        }
    }
}
