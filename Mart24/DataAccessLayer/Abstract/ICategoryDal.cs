using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    interface ICategoryDal:IRepository<Category>  // içindekileri sildim çünkü o ilk yöntemde vardı. onun yerine IRepository den deger almasını istedim.
                                                  // yani işlemlerimi generic olarak yapıcam. bu yapının adı generic tir. 
    {

    }
}
