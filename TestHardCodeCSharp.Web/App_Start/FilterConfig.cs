using System.Web.Mvc;
using SSO.Utilities;
/*add customized code between this region*/
/*add customized code between this region*/


namespace TestHardCodeCSharp.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeBaseAttribute());/*add customized code between this region*/
/*add customized code between this region*/

        }
    }
}