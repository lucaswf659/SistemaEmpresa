angular.module('sistemaempresa')
    .controller("SistemaCtrl", SistemaCtrl);

SistemaCtrl.$inject = ['$scope', 'SistemaService'];

function SistemaCtrl($scope, SistemaService)
{
    inicializaDadosSistemaCtrl();
 
    BuscarFornecedorList();

    function inicializaDadosSistemaCtrl() {

        $scope.Empresa = {
            IdEmpresa: 0,
            NomeFantasia: '',
            UF: '',
            CNPJ: ''
        }

        $scope.FornecedorFiltro = {
            IdEmpresa: 0,
            Nome: '',
            Documento: '',
            DtCadastro: undefined
        }

        $scope.FornecedorList = [];
    };

    $scope.CadastrarEmpresa = function () {
        SistemaService.CadastrarEmpresa($scope.Empresa)
            .then(function (responseSucess) {
                BuscarFornecedorList();
            }, function (errorResponse) {

                var error = errorResponse.message;
            });
    };

    $scope.CadastrarFornecedor = function () {
        SistemaService.CadastrarFornecedor($scope.Fornecedor)
            .then(function (responseSucess) {
                BuscarFornecedorList();
            }, function (errorResponse) {

                var error = errorResponse.message;
            });
    };

    $scope.CadastrarEmpresaFornecedor = function () {
        SistemaService.CadastrarEmpresaFornecedor($scope.EmpresaFornecedor)
            .then(function (responseSucess) {
                BuscarFornecedorList();
            }, function (errorResponse) {

                var error = errorResponse.message;
            });
    };

    $scope.BuscarEmpresa = function() {
        SistemaService.BuscarEmpresa($scope.Empresa)
            .then(function (responseSucess) {
                $scope.Empresa.NomeFantasia = responseSucess.data.NomeFantasia;
                BuscarFornecedorList($scope.Empresa);
            }, function (errorResponse) {

                var error = errorResponse.message;
            });
    };

    $scope.BuscarFornecedorListFiltrado = function() {
        SistemaService.BuscarFornecedorList($scope.FornecedorFiltro)
            .then(function (responseSucess) {
                $scope.FornecedorList = responseSucess.data;
                $scope.Empresa.NomeFantasia = responseSucess.data[0].empresa.NomeFantasia;
                $scope.FornecedorList.forEach(function (item) {
                    item.DtCadastro = formatDate(item.DtCadastro);
                    if (item.DtCadastro == '1/1/1')
                        item.DtCadastro = undefined;
                    item.DtNascimento = formatDate(item.DtNascimento);
                    if (item.DtNascimento == '1/1/1')
                        item.DtNascimento = undefined;
                });
                //toastr.success('Hello world!', 'Toastr fun!');
            }, function (errorResponse) {
                //toastr.error('Your credentials are gone', 'Error');
                var error = errorResponse.message;
            });
    };

    function BuscarFornecedorList() {
        SistemaService.BuscarFornecedorList($scope.Empresa)
            .then(function (responseSucess) {
                $scope.FornecedorList = responseSucess.data;
                $scope.Empresa.NomeFantasia = responseSucess.data[0].empresa.NomeFantasia;
                $scope.FornecedorList.forEach(function (item) {
                    item.DtCadastro = formatDate(item.DtCadastro);
                    if (item.DtCadastro == '1/1/1')
                        item.DtCadastro = undefined;
                    item.DtNascimento = formatDate(item.DtNascimento);
                    if (item.DtNascimento == '1/1/1')
                        item.DtNascimento = undefined;
                });
                //toastr.success('Hello world!', 'Toastr fun!');
            }, function (errorResponse) {
                //toastr.error('Your credentials are gone', 'Error');
                var error = errorResponse.message;
            });
    };

    function formatDate(timestamp) {
        var x = new Date(timestamp);
        var dd = x.getDate();
        var mm = x.getMonth() + 1;
        var yy = x.getFullYear();
        //var hh = x.getHours();
        return dd + "/" + mm + "/" + yy;
    }
}

  





