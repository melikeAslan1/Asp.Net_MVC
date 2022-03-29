using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //bizim gönderdiğimiz şartların sağlanıp sağlanmadığını business layerda kontrol ederiz.

    //concrete klasörüm somut adımları içerir.
   public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()  // T değeri yani category yani Entity gönderdim.
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName=="" || p.CategoryName.Length<3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {
                // hata mesajı
            }
            { repo.Insert(p); }
        }


    }
}
