using SistemaModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SistemaDados
{
    public class FornecedorDD
    {
        public static bool CadastrarFornecedor(Fornecedor fornecedor)
        {
            bool adicionado = false;
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-O734NVQ\\SQLEXPRESS;Database=SistemaEmpresa;Trusted_Connection=True;"))
                {

                    SqlCommand command = new SqlCommand("dbo.cadastrar_fornecedor", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@nome", fornecedor.Nome ?? string.Empty);
                    command.Parameters.AddWithValue("@rg", fornecedor.RG ?? string.Empty);
                    command.Parameters.AddWithValue("@dt_cadastro", fornecedor.DtCadastro == null ? (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue : fornecedor.DtCadastro);
                    command.Parameters.AddWithValue("@dt_nascimento", fornecedor.DtNascimento == null ? (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue : fornecedor.DtNascimento);
                    command.Parameters.AddWithValue("@telefone", fornecedor.Telefone ?? string.Empty);

                    command.Parameters.Add("@Adicionado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        adicionado = Convert.ToBoolean(command.Parameters["@Adicionado"].Value);

                        if (!adicionado)
                            throw new Exception("Não foi possível inserir os dados do fornecedor!");
                    }
                }
                return adicionado;
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

                List<Fornecedor> listaFornecedores = new List<Fornecedor>();

                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-O734NVQ\\SQLEXPRESS;Database=SistemaEmpresa;Trusted_Connection=True;"))
                {

                    SqlCommand command = new SqlCommand("[dbo].[buscar_lista_fornecedores]", connection);
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@idEmpresa", idEmpresa == 0 ? idEmpresa = 1 : idEmpresa);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Fornecedor fornecedor = new Fornecedor()
                                {
                                    Nome = reader.GetString(0),
                                    Documento = reader.GetString(1),
                                    RG = reader.GetString(2),
                                    DtCadastro = reader.GetDateTime(3),
                                    DtNascimento = reader.GetDateTime(4),
                                    Telefone = reader.GetString(5)
                                };
                                listaFornecedores.Add(fornecedor);
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                }

                return listaFornecedores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
