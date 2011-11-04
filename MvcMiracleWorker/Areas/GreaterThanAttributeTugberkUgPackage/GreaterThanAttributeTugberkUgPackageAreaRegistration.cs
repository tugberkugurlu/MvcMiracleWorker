using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.GreaterThanAttributeTugberkUgPackage
{
    public class GreaterThanAttributeTugberkUgPackageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "GreaterThanAttributeTugberkUgPackage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "GreaterThanAttributeTugberkUgPackage_default",
                "GreaterThanAttributeTugberkUgPackage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
