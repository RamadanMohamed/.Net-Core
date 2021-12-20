using lab6mvccore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.services
{
    public class DepartmentData : IOpDepartment
    {
        List<department> departmens = new List<department>()
        {
            new department() {deptid=100, deptname="sd"},
             new department() {deptid=200, deptname="java"},
              new department() {deptid=300, deptname="El"},
               new department() {deptid=400, deptname="Asp.Net"},
        };

        public department adddeparment(department dept)
        {
            departmens.Add(dept);
            return dept;
        }

        public List<department> getalldepartment()
        {
            return departmens;
        }

        public department getdepartment(int id)
        {
            return departmens.FirstOrDefault(a => a.deptid == id);
        }
    }
    }
