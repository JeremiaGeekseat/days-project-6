angular.module('myApp')
.directive('dateRange', function() {
   return {
        restrict: "E",
        scope: false,
        template: [
            '<div class="input-group">',
                '<input id="start" style="width: 50%;" value="10/10/2017" />',
                '<input id="end" style="width: 50%;" value="10/10/2017" />',
            '</div>'
        ].join("")
    };
});