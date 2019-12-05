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
                if (fornecedor == null)
                    throw new ApplicationException("Não foi possível cadastrar o fornecedor.");

                if(fornecedor.Documento.Length == 11)
                    if(fornecedor.RG == null || fornecedor.DtNascimento == DateTime.MinValue)
                        throw new ApplicationException("Fornecedores PESSOA FÍSICA devem cadastrar obrigatoriamente o RG e a Data de nascimento.");

                return FornecedorDD.CadastrarFornecedor(fornecedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Fornecedor BuscarFornecedor(int idFornecedor)
        {
            try
            {
                return FornecedorDD.BuscarFornecedor(idFornecedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Fornecedor> BuscarFornecedorList(FornecedorFiltro fornecedorFiltro)
        {
            try
            {
                return FornecedorDD.BuscarFornecedorList(fornecedorFiltro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
