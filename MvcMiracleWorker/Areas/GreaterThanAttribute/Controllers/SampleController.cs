using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMiracleWorker.Areas.GreaterThanAttribute.Models;

namespace MvcMiracleWorker.Areas.GreaterThanAttribute.Controllers {

    public class SampleController : Controller {

        public ActionResult Index() {

            return View();
        }

        [ActionName("Index"), HttpPost]
        public ActionResult Index_post(Reservation reservation) {

            if (ModelState.IsValid) {

                ViewBag.Result = "Successfully posted!";
                return View();

            } else {

                return View(reservation);
            }

        }

    }
}
