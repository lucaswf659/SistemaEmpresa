angular.module('sistemaempresa')
    .controller("SistemaCtrl", SistemaCtrl);

SistemaCtrl.$inject = ['$scope', 'SistemaService'];

function SistemaCtrl($scope, SistemaService)
{
    inicializaDadosSistemaCtrl();
    //BuscarSistema();

    function inicializaDadosSistemaCtrl() {
        
    };

    $scope.CadastrarEmpresa = function () {
        SistemaService.CadastrarEmpresa($scope.Empresa)
            .then(function (responseSucess) {
                
            }, function (errorResponse) {

                var error = errorResponse.message;
            });
    };


    $scope.CadastrarFornecedor = function () {

        //get empresa
        if ($scope.Empresa.UF == "PR") {
            //ver se é menor de idade, se for nao deixar cadastrar
        }

        SistemaService.CadastrarFornecedor($scope.Fornecedor)
            .then(function (responseSucess) {



            }, function (errorResponse) {

                var error = errorResponse.message;
            });
    };

    function BuscarSistema() {

        SistemaService.BuscarSistema()
            .then(function (responseSucess) {



            }, function (errorResponse) {

                var error = errorResponse.message;
            });
    }

    function formatDate(timestamp) {
        var x = new Date(timestamp);
        var dd = x.getDate();
        var mm = x.getMonth() + 1;
        var yy = x.getFullYear();
        //var hh = x.getHours();
        return dd + "/" + mm + "/" + yy;
    }
}

  





