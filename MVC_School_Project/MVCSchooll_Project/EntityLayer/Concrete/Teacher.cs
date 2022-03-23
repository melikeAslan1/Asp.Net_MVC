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

        [StringLength(15)]
        public string TeacherName { get; set; }

        [StringLength(15)]
        public string TeacherSurname { get; set; }

        [StringLength(10)]
        public string TeacherPhone { get; set; }

        public ICollection<Student> Students { get; set; }
        
    }
}
