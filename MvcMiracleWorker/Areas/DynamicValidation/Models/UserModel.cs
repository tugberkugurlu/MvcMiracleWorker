using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMiracleWorker.Areas.DynamicValidation.Models {

    public class UserModel {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Range(18, 80)]
        public int Age { get; set; }

    }
}