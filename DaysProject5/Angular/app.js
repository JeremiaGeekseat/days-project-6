angular.module('myApp', ["ngRoute"])
.config(function($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl : "home.html",
        controller : "movieController"
    })
        .when("/movie", {
        templateUrl : "movie.html",
        controller : "movieController"
    })
    .otherwise( { redirectTo: "/" } );
});

//$(document).ready(function () {

//    function startChange() {
//        var startDate = startDateRange.value(),
//            endDate = endDateRange.value();

//        if (startDate) {
//            startDate = new Date(startDate);
//            startDate.setDate(startDate.getDate());
//            endDateRange.min(startDate);
//        } else if (endDate) {
//            startDateRange.max(new Date(endDate));
//        } else {
//            endDate = new Date();
//            startDateRange.max(endDate);
//            endDateRange.min(endDate);
//        }
//    }

//    function endChange() {
//        var endDate = endDateRange.value(),
//            startDate = startDateRange.value();

//        if (endDate) {
//            endDate = new Date(endDate);
//            endDate.setDate(endDate.getDate());
//            startDateRange.max(endDate);
//        } else if (startDate) {
//            endDateRange.min(new Date(startDate));
//        } else {
//            endDate = new Date();
//            startDateRange.max(endDate);
//            endDateRange.min(endDate);
//        }
//    }

//    var startDateRange = $("#start").kendoDatePicker({
//        change: startChange
//    }).data("kendoDatePicker");

//    var endDateRange = $("#end").kendoDatePicker({
//        change: endChange
//    }).data("kendoDatePicker");

//    startDateRange.max(endDateRange.value());
//    endDateRange.min(startDateRange.value());
//});