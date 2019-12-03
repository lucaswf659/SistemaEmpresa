angular.module('sistemaempresa', ['ngRoute'])
    .config(function ($routeProvider) {

        $routeProvider
            .when('/sistema', {
                templateUrl: 'app/views/main.html',
                controller: 'SistemaCtrl'
            })

            .otherwise({
                redirectTo: '/sistema'
            });

    });