using System.Web;
using System.Web.Mvc;

namespace CRUD_MVC_Operations_Users
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}