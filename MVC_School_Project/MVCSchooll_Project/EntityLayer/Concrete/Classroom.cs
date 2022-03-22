using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    class Classroom
    {
        public int ClassroomId { get; set; }

        public int ClassroomName { get; set; }

        public IColection<Student> Students { get; set; }
    }
}
