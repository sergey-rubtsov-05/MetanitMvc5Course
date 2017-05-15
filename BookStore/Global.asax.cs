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
            DbContextFactory.ConnectionString = $"Data Source='{Server.MapPath(@"~\App_Data\Bookstore.sqlite")}';Version=3";

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
