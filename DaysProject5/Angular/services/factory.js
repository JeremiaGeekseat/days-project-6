angular.module('myApp')
    .factory('simpleFactory', function ($http) {
        return {
            getMovies: function () {
                return $http.get('Movies/GetMovies');
            }
        }
    });