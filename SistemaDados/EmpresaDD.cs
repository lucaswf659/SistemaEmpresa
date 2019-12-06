using SistemaDados.Properties;
using SistemaModelos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaDados
{
    public class EmpresaDD
    {
        public static bool CadastrarEmpresa(Empresa empresa)
        {
            bool adicionado = false;
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-O734NVQ\\SQLEXPRESS;Database=SistemaEmpresa;Trusted_Connection=True;"))
                {

                    SqlCommand command = new SqlCommand("dbo.cadastrar_empresa", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@uf", empresa.UF);
                    command.Parameters.AddWithValue("@nome_empresa", empresa.NomeFantasia);
                    command.Parameters.AddWithValue("@cnpj", empresa.CNPJ);
                    
                    command.Parameters.Add("@Adicionado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        adicionado = Convert.ToBoolean(command.Parameters["@Adicionado"].Value);

                        if (!adicionado)
                            throw new Exception("Não foi possível inserir os dados da empresa!");
                    }
                }
                return adicionado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Empresa BuscarEmpresa(int idEmpresa)
        {
            try
            {

                Empresa empresa = new Empresa();

                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-O734NVQ\\SQLEXPRESS;Database=SistemaEmpresa;Trusted_Connection=True;"))
                {

                    SqlCommand command = new SqlCommand("[dbo].[buscar_empresa]", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@idEmpresa", SqlDbType.Int).Value = idEmpresa == 0 ? idEmpresa = 1 : idEmpresa;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                empresa.NomeFantasia = reader.GetString(0);
                                empresa.UF = reader.GetString(1);
                                empresa.CNPJ = reader.GetString(2);
                            }
                        }
                        else
                        {
                           throw new ApplicationException("Empresa não encontrada.");
                        }
                    }
                }

                return empresa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
