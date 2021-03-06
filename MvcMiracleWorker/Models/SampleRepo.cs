﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMiracleWorker.Models {

    public class SampleRepo {

        public IEnumerable<Sample> GetAll() {

            var model = new List<Sample>();

            #region

            model.Add(new Sample { 
                SampleName = "Donut Hole Caching",
                Area = "DonutHoleCaching", 
                Description = "This sample demonstrates a very basic implementation of so called Donut Hole Caching" 
            });

            model.Add(new Sample { 
                SampleName = "GreaterThan Custom Validation", 
                Area = "GreaterThanAttribute",
                Description = "GreaterThanAttribute custom validation working demo"
            });

            model.Add(new Sample { 
                SampleName = "GreaterThan Custom Validation (TugberkUg.MVC NuGet Package)", 
                Area = "GreaterThanAttributeTugberkUgPackage",
                Description = "Demo of GreaterThanDate Validation Attribute From TugberkUg.MVC NuGet package"
            });

            model.Add(new Sample {
                SampleName = "File Upload",
                Area = "FileUpload",
                Description = "Demo of a File Upload Scenario"
            });

            model.Add(new Sample {
                SampleName = "HTML Select Element",
                Area = "SelectList",
                Description = "Demo of Genereting a HTML Select Element"
            });

            #endregion

            return model;
        }

    }
}