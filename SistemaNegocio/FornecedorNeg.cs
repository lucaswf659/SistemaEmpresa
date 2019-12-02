using SistemaDados;
using SistemaModelos;
using System;

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
    }
}
