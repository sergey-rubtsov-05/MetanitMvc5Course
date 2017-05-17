using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BookStore.Models;

namespace BookStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DbContextFactory.DbFileName = Server.MapPath(@"~\App_Data\Bookstore.sqlite");

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
