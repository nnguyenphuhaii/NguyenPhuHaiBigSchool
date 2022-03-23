using System.Web;
using System.Web.Mvc;

namespace BigSchoolNguyenPhuHai1911060736
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
