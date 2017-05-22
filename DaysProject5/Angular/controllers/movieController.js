angular.module('myApp')
    .controller('movieController', function ($scope, simpleFactory) {
        $scope.movies = [];

        $scope.init = function () {
            simpleFactory.getMovies().then(function (response) {
                $scope.movies = response.data;
            });
        }

        $scope.formatDate = function (str) {
            var unix = str.substring(6, str.length-2);
            var date = new Date(parseInt(unix)+10000000000);
            return date.getMonth() + "/" + date.getDate() + "/" + date.getFullYear();
        }

        $scope.lengthh = function() {
            return $scope.movies.length;
        }
    });