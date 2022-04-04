using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetList();

        void CategoryAddBL(Category category);

        Category GetByID(int id);
        //Dışardan ıd değişkenini alacaksın 

        void CategoryDelete(Category category);

        void CategoryUpdate(Category category);
    }
}
