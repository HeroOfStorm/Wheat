using Helpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpers.Controllers
{
    public class NavController : Controller
    {
        static List<Student> students = StudentRepository.GetRepository();
        public PartialViewResult Menu()
        {
            IEnumerable<string> groups = students
                .Select(x => x.Group)
                .Distinct()
                .ToList();
            return PartialView(groups);
        }
    }
}