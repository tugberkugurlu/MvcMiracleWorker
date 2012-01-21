using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMiracleWorker.Areas.DynamicValidation.Models;
using TugberkUg.MVC.Helpers;

namespace MvcMiracleWorker.Areas.DynamicValidation.Controllers {

    public class SampleController : Controller {

        private readonly UserModel user = new UserModel {
            Name = "Tugberk",
            Surname = "Ugurlu",
            Age = 25
        };

        public ActionResult Index() {

            return View(user);
        }

        public JsonResult EditAjax() {

            if (Request.IsAjaxRequest()) {

                return Json(new { data = this.RenderPartialViewToString("_UserCreate", user) }, JsonRequestBehavior.AllowGet);
            }

            return null;
        }

        public JsonResult DetailsAjax() {

            if (Request.IsAjaxRequest()) {

                return Json(new { data = this.RenderPartialViewToString("_UserDetails", user) }, JsonRequestBehavior.AllowGet);
            }

            return null;
        }
    }
}