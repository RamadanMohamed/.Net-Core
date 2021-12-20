using lab6mvccore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.services
{
   public interface IStudentOp
    {
        List<Student> GetAllStudent();
        Student addstudent(Student std);
        Student UpdateStudent(Student std);
        Student getstudent(int Id);

        Student DeleteStudent(int id);



    }
}
