using System.Web;
using System.Web.Mvc;

namespace Ilk_MVC_Projem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
