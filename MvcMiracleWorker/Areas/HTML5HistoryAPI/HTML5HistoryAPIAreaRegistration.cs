using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.HTML5HistoryAPI
{
    public class HTML5HistoryAPIAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "HTML5HistoryAPI";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {

            context.MapRoute(
                "HTML5HistoryAPI_default",
                "HTML5HistoryAPI/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
