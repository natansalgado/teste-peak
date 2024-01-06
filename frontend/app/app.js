angular.module('peak', ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $locationProvider.html5Mode(true);

        $routeProvider
            .when('/', {
                templateUrl: 'app/pages/calc.html',
                controller: 'calcController'
            })
            .when('/consult', {
                templateUrl: 'app/pages/consult.html',
                controller: 'consultController'
            })
            .otherwise({ redirectTo: '/' });
    })
    .controller('mainController', function ($scope, $route) {
        $scope.isActiveController = (controllerName) => {
            return $route.current && $route.current.controller === controllerName;
        }
    })