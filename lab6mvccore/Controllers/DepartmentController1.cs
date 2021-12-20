using lab6mvccore.services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.Controllers
{
    
    public class DepartmentController1 : Controller
    {
        
        public DepartmentController1()
        {
            
        }
        
        public IActionResult Index([FromServices]IOpDepartment dp)
        {
            return View();  

        }
    }
}
