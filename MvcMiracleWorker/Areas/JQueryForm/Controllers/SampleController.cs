using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMiracleWorker.Areas.JQueryForm.Models;

namespace MvcMiracleWorker.Areas.JQueryForm.Controllers {

    public class SampleController : Controller {

        public ActionResult Index() {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Reservation reservation) {

            return Json(new { 
                hotelName = reservation.HotelName + " from Server", 
                checkIn = reservation.CheckIn, 
                checkOut = reservation.CheckOut 
            });
        }

    }
}
