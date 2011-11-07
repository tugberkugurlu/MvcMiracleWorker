using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.JQueryCycle
{
    public class JQueryCycleAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "JQueryCycle";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "JQueryCycle_default",
                "JQueryCycle/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
