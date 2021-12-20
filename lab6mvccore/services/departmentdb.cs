using lab6mvccore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.services
{
    public class departmentdb : IOpDepartment
    {
        private ITIModel _dept;

        public departmentdb(ITIModel dept)
        {
            _dept = dept;
        }
        public department adddeparment(department dept)
        {
            _dept.departments.Add(dept);
            _dept.SaveChanges();
            return dept;
        }

        public List<department> getalldepartment()
        {
            return _dept.departments.ToList<department>();         
        }

        public department getdepartment(int id)
        {
            throw new NotImplementedException();
        }
    }
}
