using Helpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpers.Controllers
{
    public class AdminController : Controller
    {
        static int studentsOnPage = 3;
        static List<Student> students = StudentRepository.GetRepository();
        public ActionResult Index(int id = 1)
        {
            ViewBag.Students = students;
           
            return View();
        }

        public ActionResult Edit(int id)
        {
            Student s = null;
            if (id != 0)
                s = students.FirstOrDefault(x => x.Id == id);
                
            return View(s);
        }

        [HttpPost]
        public ActionResult Edit(Student a)
        {
            if (ModelState.IsValid)
            {
                
                int index = students
                    .IndexOf(students.FirstOrDefault(x => x.Id == a.Id));
                if (index != -1)
                    students[index] = a;
                else
                {
                    students.Add(a);
                    a.Id = students.Max(x => x.Id) + 1;
                }
                return RedirectToAction("Index");
            }
            else
                return View(a);
        }

        public PartialViewResult GetTable(int id = 1)
        {
            if (Request["g"] != null)
               studentsOnPage = Convert.ToInt32(Request["g"]);
            
            ViewBag.Students = students.Skip((id - 1) * studentsOnPage).Take(studentsOnPage);
            ViewBag.PageCount = Math.Ceiling(students.Count / (double)studentsOnPage);
            return PartialView();
        }
      
        public ActionResult Remove(int? id = null)
        {
            if (id != null)
            {
                Student temp = students.FirstOrDefault(x => x.Id == id);
                students.Remove(temp);
            }
            return RedirectToAction("GetTable");
        }


    }
}