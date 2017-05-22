angular.module('myApp')
    .controller('movieController', function ($scope, simpleFactory) {
        $scope.movies = [];

        $scope.init = function () {
            simpleFactory.getMovies().then(function (response) {
                $scope.movies = response.data;
            });
        }
        
    });