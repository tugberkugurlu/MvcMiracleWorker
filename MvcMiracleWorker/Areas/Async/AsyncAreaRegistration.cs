using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.Async
{
    public class AsyncAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Async";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Async_default",
                "Async/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
