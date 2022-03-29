using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    //Generic Repository sayesinde bütün interface lerde geçerli olan mimariyi kurmuş olurum. Artık WriterRepository
    //yada CategoryRepository tanımlamama gerek yok. amaç: kod tekrarından kurtulmak, işlemlerin daha kolay ilerlemesi,
    // böl parçala yönet ile proje geliştirmek. Bunun daha büyüğü mikroservisler ile olan mimariler falan.
    public class GenericRepository<T> : IRepository<T> where T : class   //Generic bütün klasörlerin tamamını kaplıyor. Burada T değerim class olacak diyorum. T yi zaten Entity olarak gönderiyoruz.
    {
        Context c = new Context();

        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();

        }


        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
           
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter) //şartlı listeleme
        {
            return _object.Where(filter).ToList();

        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
