using SistemaModelos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaDados
{
    public class EmpresaFornecedorDD
    {
        public static bool CadastrarEmpresaFornecedor(EmpresaFornecedor empresaFornecedor)
        {
            bool adicionado = false;
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-O734NVQ\\SQLEXPRESS;Database=SistemaEmpresa;Trusted_Connection=True;"))
                {

                    SqlCommand command = new SqlCommand("dbo.cadastrar_empresa_fornecedor", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id_empresa", empresaFornecedor.IdEmpresa);
                    command.Parameters.AddWithValue("@id_fornecedor", empresaFornecedor.IdFornecedor);
                 

                    command.Parameters.Add("@Adicionado", SqlDbType.Bit).Direction = ParameterDirection.Output;


                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        adicionado = Convert.ToBoolean(command.Parameters["@Adicionado"].Value);

                        if (!adicionado)
                            throw new Exception("Não foi possível inserir o fornecedor na empresa!");
                    }
                }
                return adicionado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
