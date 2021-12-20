using lab6mvccore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.services
{
   public interface IOpDepartment
    {
        List<department> getalldepartment();
        department getdepartment(int id);
        department adddeparment(department dept);
    }
}
