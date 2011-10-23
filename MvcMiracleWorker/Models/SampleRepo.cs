using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMiracleWorker.Models {

    public class SampleRepo {

        public IEnumerable<Sample> GetAll() {

            var model = new List<Sample>();

            model.Add(new Sample { SampleName = "Donut Hole Caching", Area = "DonutHoleCaching", 
                Description = "This sample demonstrates a very basic implementation of so called Donut Hole Caching" });

            return model;
        }

    }
}