using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }

        [StringLength(10)]
        public string LessonName { get; set; }

        public int Grade { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
