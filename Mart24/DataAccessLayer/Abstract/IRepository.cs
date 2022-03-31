using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IRepository<T>    //burada metotların tanımlamasını yaptık.  //repository işlemleri için kullanacağımız temel interface.
    {
        List<T> List();

        void Insert(T p);
        void Update(T p);
        void Delete(T p);

        List<T> List(Expression<Func<T, bool>>filter);  //filtreleme işlemi yapıcaz, landa diye geçiyor. bu yapının adı generic.


    }
}
