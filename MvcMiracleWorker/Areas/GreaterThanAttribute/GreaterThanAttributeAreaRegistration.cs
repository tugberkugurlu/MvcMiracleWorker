using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.GreaterThanAttribute
{
    public class GreaterThanAttributeAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "GreaterThanAttribute";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "GreaterThanAttribute_default",
                "GreaterThanAttribute/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
