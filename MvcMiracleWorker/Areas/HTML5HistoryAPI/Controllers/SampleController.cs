using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TugberkUg.MVC.Helpers;

namespace MvcMiracleWorker.Areas.HTML5HistoryAPI.Controllers {

    public class SampleController : Controller {

        public ActionResult Index() {

            if (Request.IsAjaxRequest()) {
                return Json(new { result = string.Empty }, JsonRequestBehavior.AllowGet);
            }

            return View();
        }

        public ActionResult City(string q) {

            System.Threading.Thread.Sleep(2000);

            ViewBag.Content = string.Format("You have requested for city {0}", q);

            if (Request.IsAjaxRequest()) {

                return Json(new { result = this.RenderPartialViewToString("_CityInfo") }, JsonRequestBehavior.AllowGet);
            }

            return View("index");
        }
    }
}