using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMiracleWorker.Models;

namespace MvcMiracleWorker.Controllers {

    public class HomeController : Controller {

        SampleRepo repo = new SampleRepo();

        public ActionResult Index() {

            var model = repo.GetAll();

            return View(model);
        }

        public ActionResult About() {

            return View();
        }

    }
}