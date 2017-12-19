using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Helpers.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введи имя!")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Введи возраст!")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Введи группу!")]
        public string Group { get; set; }
        //public string Image
        //{
        //    get
        //    {
        //        return Id + ".jpg";
        //    }
        //}
        public string Image { get; set; }
    }
}