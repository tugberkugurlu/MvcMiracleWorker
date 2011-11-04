using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMiracleWorker.Areas.GreaterThanAttribute.Infrastructure.Validation {

    public class GreaterThanDateAttribute : ValidationAttribute {

        public string OtherPropertyName { get; set; }

        public GreaterThanDateAttribute(string otherPropertyName) :
            base("{0} must be greater than {1}") {

            OtherPropertyName = otherPropertyName;
        }

        public override string FormatErrorMessage(string name) {

            return string.Format(ErrorMessageString, name, OtherPropertyName);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {

            var otherPropertyInfo = validationContext.ObjectType.GetProperty(OtherPropertyName);
            var otherDate = (DateTime)otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);
            var thisDate = (DateTime)value;

            if (thisDate <= otherDate) {

                var message = FormatErrorMessage(validationContext.DisplayName);
                return new ValidationResult(message);
            }

            return null;
        }

    }
}