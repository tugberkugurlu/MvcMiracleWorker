using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMiracleWorker.Areas.GreaterThanAttribute.Infrastructure.Validation;

namespace MvcMiracleWorker.Areas.GreaterThanAttribute.Models {

    public class Reservation {

        public string HotelName { get; set; }
        public DateTime CheckIn { get; set; }
        [GreaterThanDate("CheckIn")]
        public DateTime CheckOut { get; set; }

    }
}