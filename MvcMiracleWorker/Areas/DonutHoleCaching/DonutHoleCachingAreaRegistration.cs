using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.DonutHoleCaching
{
    public class DonutHoleCachingAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "DonutHoleCaching";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "DonutHoleCaching_default",
                "DonutHoleCaching/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
