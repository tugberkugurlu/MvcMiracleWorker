/// <reference path="jquery-1.7-vsdoc.js" />
/// <reference path="jquery.validate-vsdoc.js" />
/// <reference path="jquery.validate.unobtrusive.js" />

jQuery.validator.addMethod("greaterthandate", function (value, element, param) {

    return Date.parse(value) > Date.parse($(param).val());
});

jQuery.validator.unobtrusive.adapters.add("greaterthandate", ["otherpropertyname"], function (options) {
    options.rules["greaterthandate"] = "#" + options.params.otherpropertyname
    options.messages["greaterthandate"] = options.message;
});