using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpers.Models
{
    public class StudentViewModel
    {
        public IEnumerable<Student> Students { get; set; }
        public PageLinksModel Pages { get; set; }
        public string Group { get; set; }
    }
}