using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMiracleWorker.Areas.DonutHoleCaching.Controllers {

    public class SampleController : Controller {

        public ActionResult Index() {

            return View();
        }

        [ChildActionOnly]
        [OutputCache(Duration=60)]
        public ActionResult sampleChildAction() {

            //Put the thread at sleep for 3 seconds to see the difference.
            System.Threading.Thread.Sleep(3000);

            //Also pass the date time from here just to see that it is comming from here.
            ViewBag.DateTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss");

            return View();
        }

    }
}