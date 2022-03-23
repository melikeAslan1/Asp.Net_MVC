using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context: DbContext
    {
        
        public DbSet<Classroom> MyProperty { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<Teacher> Teachers { get; set; }


    }
}
