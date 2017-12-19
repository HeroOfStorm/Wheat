﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpers.Models
{
    public class StudentRepository
    {
        static List<Student> students = new List<Student>
        {
           new Student { Id = 1, Name = "Luxsemburg Loler", Age = 32, Group = "19п1_26",Image="http://365sitesupport.co.uk/wp-content/uploads/loler.jpg" },
           new Student { Id = 2, Name = "Jack Daniel", Age = 32, Group = "19п1_26",Image="https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Jackdaniel.jpg/200px-Jackdaniel.jpg"  },
           new Student { Id = 3, Name = "Alex Spark", Age = 25, Group = "19п1_26" ,Image="data:image/jpeg;base64,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" },
           new Student { Id = 4, Name = "William Peel", Age = 12, Group = "19п1_26" ,Image="https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Peel_4690776328_1a4e06f632_o.jpg/220px-Peel_4690776328_1a4e06f632_o.jpg" },
           new Student { Id = 5, Name = "Jason Statham", Age = 15, Group = "19п1_26" ,Image="https://www.thesun.co.uk/wp-content/uploads/2016/09/gettyimages-530708802.jpg?w=720" },
           new Student { Id = 6, Name = "Arnold John", Age = 22, Group = "19п1_26",Image=""  },
           new Student { Id = 7, Name = "Justin Gay", Age = 30, Group = "19п1_26" ,Image="" },
           new Student { Id = 8, Name = "Igor Pashkovsky", Age = 27, Group = "19п1_26" ,Image="" },
           new Student { Id = 9, Name = "Dart Veydar", Age = 31, Group = "19п1_26"  ,Image=""},
           new Student { Id = 10, Name = "Luk Besson", Age = 19, Group = "19п1_26" ,Image="" },
           new Student { Id = 11, Name = "Dan Brown", Age = 22, Group = "19п1_26" ,Image="" }

        };
        public static List<Student> GetRepository()
        {
            return students;
        }
    }
}