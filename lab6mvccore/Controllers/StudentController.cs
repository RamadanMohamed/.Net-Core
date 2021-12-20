using lab6mvccore.Models;
using lab6mvccore.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.Controllers
{
    public class StudentController : Controller
    {
        IStudentOp sd;
       private IOpDepartment _ideptop;

        public StudentController(IStudentOp _sd,IOpDepartment ideptop)
        {
            sd = _sd;
            _ideptop = ideptop;
        }
        public IActionResult Index()
        {
            return View(sd.GetAllStudent());
        }
        [HttpGet]
        public IActionResult Create()
        {
           ViewBag.depts = new SelectList(_ideptop.getalldepartment(), "deptid", "deptname");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            
                sd.addstudent(std);
                return RedirectToAction("Index");
          
        }
       
        
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var std = sd.getstudent(id);
            return View(std);
        }
        [HttpPost]
        public IActionResult Update(Student std)
        {
            sd.UpdateStudent(std);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            sd.DeleteStudent(id);
            return RedirectToAction("Index");
        }
        public IActionResult ShowStudentData(int id)
        {
            var std=sd.getstudent(id);
            return View(std);
        }
    }
}
