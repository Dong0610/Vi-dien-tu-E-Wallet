using System.Web;
using System.Web.Mvc;

namespace Vi_dien_tu_E_Wallet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
