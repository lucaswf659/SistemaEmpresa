angular.module('sistemaempresa')
    .service('SistemaService', SistemaService);

SistemaService.$inject = ['$http'];

function SistemaService($http) {

    
    this.CadastrarEmpresa = function ($scope) {
        return $http.post('http://localhost:60791/api/Empresa/CadastrarEmpresa', $scope);
    };

    this.BuscarEmpresa = function () {
        return $http.get('http://localhost:60791/api/Empresa/BuscarEmpresa?idEmpresa=' + '0');
    };

    this.CadastrarFornecedor = function ($scope) {
        return $http.post('http://localhost:60791/api/Fornecedor/CadastrarFornecedor', $scope);
    };

    this.BuscarFornecedoresList = function ($scope) {
        return $http.get('http://localhost:60791/api/Fornecedor/BuscarFornecedoresList', $scope);
    };


    var self = this;
}
     
   


