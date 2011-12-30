using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.SelectList
{
    public class SelectListAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SelectList";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "SelectList_default",
                "SelectList/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
