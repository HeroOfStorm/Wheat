using Helpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpers.Controllers
{
    public class StudentController : Controller
    {
        int pagesize = 3;
        static List<Student> students = StudentRepository.GetRepository();
        public ActionResult Index(int id = 1)
        {
            StudentViewModel model = new StudentViewModel
            {
                Students = students.Skip((id - 1) * pagesize).Take(pagesize),
                Pages = new PageLinksModel
                {
                    CurrentPage = id,
                    TotalItems = students.Count(),
                    CountPerPage = pagesize
                }
            };
        
         
            return View(model);
        }
     
        public PartialViewResult GetStudentsList(int id = 1)
        {
            StudentViewModel model = new StudentViewModel
            {
                Students = students.Skip((id -1)*pagesize).Take(pagesize),
                Pages = new PageLinksModel
                {
                    CurrentPage = id,
                    TotalItems = students.Count(),
                    CountPerPage = pagesize
                }
            };

            return PartialView(model);
        }

        
    }
}