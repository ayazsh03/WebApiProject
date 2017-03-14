using System.Web;
using System.Web.Mvc;
using System.Web.Http.Filters;
using LuckyMasale.WebApi.Filters;

namespace LuckyMasale.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        /// <summary>
        /// Registers the http filters.
        /// </summary>
        /// <param name="filters">The filters.</param>
        public static void RegisterHttpFilters(HttpFilterCollection filters)
        {
            filters.Add(new TokenValidationAttribute());
        }
    }
}
