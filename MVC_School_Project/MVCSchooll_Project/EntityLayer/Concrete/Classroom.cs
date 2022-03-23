using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }

        [StringLength(20)]
        public int ClassroomName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
