using SistemaDados;
using SistemaModelos;
using System;
using System.Collections.Generic;

namespace SistemaNegocio
{
    public class FornecedorNeg
    {
        public static bool CadastrarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                return FornecedorDD.CadastrarFornecedor(fornecedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Fornecedor> BuscarListaFornecedores(int idEmpresa)
        {
            try
            {
                return FornecedorDD.BuscarListaFornecedores(int idEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
