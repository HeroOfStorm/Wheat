using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpers.Models
{
    public class StudentRepository
    {
        static List<Student> students = new List<Student>
        {
           new Student { Id = 1, Name = "Luxsemburg Loler", Age = 32, Group = "19п1_26"   },
           new Student { Id = 2, Name = "Jack Daniel", Age = 32, Group = "19п1_26"  },
           new Student { Id = 3, Name = "Alex Spark", Age = 25, Group = "19п1_26"  },
           new Student { Id = 4, Name = "William Peel", Age = 12, Group = "19п1_26"  },
           new Student { Id = 5, Name = "Jason Statham", Age = 15, Group = "19п1_26"  },
           new Student { Id = 6, Name = "Arnold John", Age = 22, Group = "19п1_26"  },
           new Student { Id = 7, Name = "Justin Gay", Age = 30, Group = "19п1_26"  },
           new Student { Id = 8, Name = "Igor Pashkovsky", Age = 27, Group = "19п1_26"  },
           new Student { Id = 9, Name = "Dart Veydar", Age = 31, Group = "19п1_26"  },
           new Student { Id = 10, Name = "Luk Besson", Age = 19, Group = "19п1_26"  },
           new Student { Id = 11, Name = "Dan Brown", Age = 22, Group = "19п1_26"  }

        };
        public static List<Student> GetRepository()
        {
            return students;
        }
    }
}