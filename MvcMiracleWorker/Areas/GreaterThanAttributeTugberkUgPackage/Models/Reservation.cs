using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugberkUg.MVC.Validation;

namespace MvcMiracleWorker.Areas.GreaterThanAttributeTugberkUgPackage.Models {

    public class Reservation {

        public string HotelName { get; set; }
        public DateTime CheckIn { get; set; }
        [GreaterThanDate("CheckIn")]
        public DateTime CheckOut { get; set; }

    }
}