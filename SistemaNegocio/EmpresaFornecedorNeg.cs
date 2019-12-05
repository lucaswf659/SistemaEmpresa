using SistemaDados;
using SistemaModelos;
using System;

namespace SistemaNegocio
{
    public class EmpresaFornecedorNeg
    {
        public static bool CadastrarEmpresaFornecedor(EmpresaFornecedor empresaFornecedor)
        {
            try
            {
                Empresa empresa = EmpresaNeg.BuscarEmpresa(empresaFornecedor.IdEmpresa);

                if (empresa == null)
                    throw new ApplicationException("Empresa não encontrada.");
                if (empresa.UF == null)
                    throw new ApplicationException("UF da empresa não cadastrada.");

                Fornecedor fornecedor = FornecedorNeg.BuscarFornecedor(empresaFornecedor.IdFornecedor);

                if (fornecedor == null)
                    throw new ApplicationException("Fornecedor não encontrado.");
                if (fornecedor.Documento == null)
                    throw new ApplicationException("Documento do fornecedor não foi cadastrado.");
                if (fornecedor.DtNascimento == null)
                    throw new ApplicationException("Data de nascimento do fornecedor não foi cadastrado.");

                if (empresa.UF == "PR") 
                    if (fornecedor.Documento.Length == 11) 
                        if(fornecedor.DtNascimento < DateTime.Now.AddYears(-18))
                            throw new ApplicationException("A empresa é do Paraná, portanto não aceita fornecedores PESSOA FÍSICA menores de idade.");
                        
                return EmpresaFornecedorDD.CadastrarEmpresaFornecedor(empresaFornecedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
