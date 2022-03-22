using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        public string TeacherName { get; set; }

        public string TeacherSurname { get; set; }

        public string TeacherPhone { get; set; }

        public ICollection<Student> Students { get; set; }
        
    }
}
