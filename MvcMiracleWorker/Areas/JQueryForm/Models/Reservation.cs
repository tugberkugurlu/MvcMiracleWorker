using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMiracleWorker.Areas.JQueryForm.Models
{
    public class Reservation
    {
        public string HotelName { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}