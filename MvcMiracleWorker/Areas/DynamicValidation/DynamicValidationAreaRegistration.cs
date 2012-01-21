using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.DynamicValidation
{
    public class DynamicValidationAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "DynamicValidation";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "DynamicValidation_default",
                "DynamicValidation/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
