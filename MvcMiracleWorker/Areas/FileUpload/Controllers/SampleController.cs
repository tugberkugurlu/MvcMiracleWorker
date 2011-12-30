using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.FileUpload.Controllers {

    public class SampleController : Controller {

        public ActionResult Index() {
            return View();
        }

        [ActionName("Index")]
        [ValidateAntiForgeryToken, HttpPost]
        public ActionResult Index_post(HttpPostedFileBase File) {

            //Check if the file is not null and content length is bigger than 0
            if (File != null && File.ContentLength > 0) {

                //Check if folder is there
                if(!System.IO.Directory.Exists(Server.MapPath("~/Content/PostedFiles")))
                    System.IO.Directory.CreateDirectory(
                        Server.MapPath("~/Content/PostedFiles")
                    );

                //Set the full path
                string path = System.IO.Path.Combine(
                    Server.MapPath("~/Content/PostedFiles"),
                    System.IO.Path.GetFileName(File.FileName)
                );

                //Save the thing
                File.SaveAs(path);

                TempData["Result"] = "File created successfully!";
            }

            //RedirectToAction so that we can get rid of so-called "Form Resubmission"
            return RedirectToAction("Index");
        }

    }
}
