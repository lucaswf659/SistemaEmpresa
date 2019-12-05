angular.module('sistemaempresa')
    .service('SistemaService', SistemaService);

SistemaService.$inject = ['$http'];

function SistemaService($http) {

    
    this.CadastrarEmpresa = function ($scope) {
        return $http.post('http://localhost:60791/api/Empresa/CadastrarEmpresa', $scope);
    };

    this.BuscarEmpresa = function ($scope) {
        return $http.post('http://localhost:60791/api/Empresa/BuscarEmpresa', $scope);
    };

    this.CadastrarFornecedor = function ($scope) {
        return $http.post('http://localhost:60791/api/Fornecedor/CadastrarFornecedor', $scope);
    };

    this.BuscarFornecedorList = function ($scope) {
        return $http.post('http://localhost:60791/api/Fornecedor/BuscarFornecedorList', $scope);
    };

    this.CadastrarEmpresaFornecedor = function ($scope) {
        return $http.post('http://localhost:60791/api/EmpresaFornecedor/CadastrarEmpresaFornecedor', $scope);
    };

    var self = this;
}
     
   


