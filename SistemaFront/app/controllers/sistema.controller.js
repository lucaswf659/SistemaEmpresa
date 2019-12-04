angular.module('sistemaempresa')
    .controller("SistemaCtrl", SistemaCtrl);

SistemaCtrl.$inject = ['$scope', 'SistemaService'];

function SistemaCtrl($scope, SistemaService)
{
    inicializaDadosSistemaCtrl();
    BuscarEmpresa();

    function inicializaDadosSistemaCtrl() {
        $scope.Empresa = {
            NomeFantasia: '',
            UF: '',
            CNPJ: ''
        }
    };

    $scope.CadastrarEmpresa = function () {
        SistemaService.CadastrarEmpresa($scope.Empresa)
            .then(function (responseSucess) {
                
            }, function (errorResponse) {

                var error = errorResponse.message;
            });
    };

    function BuscarEmpresa()  {
        SistemaService.BuscarEmpresa()
            .then(function (responseSucess) {
                $scope.Empresa.NomeFantasia = responseSucess.data.NomeFantasia;
            }, function (errorResponse) {

                var error = errorResponse.message;
            });
    };

    $scope.CadastrarFornecedor = function () {

        //get empresa
        //if ($scope.Empresa.UF == "PR") {
            //ver se é menor de idade, se for nao deixar cadastrar
        //}

        SistemaService.CadastrarFornecedor($scope.Fornecedor)
            .then(function (responseSucess) {



            }, function (errorResponse) {

                var error = errorResponse.message;
            });
    };

   
}

  





