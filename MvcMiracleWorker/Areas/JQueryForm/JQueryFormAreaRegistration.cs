using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.JQueryForm
{
    public class JQueryFormAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "JQueryForm";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "JQueryForm_default",
                "JQueryForm/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
