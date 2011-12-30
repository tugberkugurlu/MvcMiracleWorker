using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.FileUpload
{
    public class FileUploadAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "FileUpload";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "FileUpload_default",
                "FileUpload/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
