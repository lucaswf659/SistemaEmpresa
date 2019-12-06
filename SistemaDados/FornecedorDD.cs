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
                    command.Parameters.AddWithValue("@Documento", fornecedor.Documento ?? string.Empty);
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

        public static List<Fornecedor> BuscarFornecedorList(FornecedorFiltro fornecedorFiltro)
        {
            try
            {

                List<Fornecedor> listaFornecedores = new List<Fornecedor>();

                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-O734NVQ\\SQLEXPRESS;Database=SistemaEmpresa;Trusted_Connection=True;"))
                {

                    SqlCommand command = new SqlCommand("[dbo].[buscar_lista_fornecedores]", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@idEmpresa", SqlDbType.Int).Value = fornecedorFiltro.IdEmpresa == 0 ? fornecedorFiltro.IdEmpresa = 1 : fornecedorFiltro.IdEmpresa;

                    if (!string.IsNullOrWhiteSpace(fornecedorFiltro.Nome))
                        command.Parameters.Add("@nome", SqlDbType.NVarChar).Value = fornecedorFiltro.Nome;

                    if (!(fornecedorFiltro.DtCadastro == DateTime.MinValue))
                        command.Parameters.Add("@dt_cadastro", SqlDbType.DateTime).Value = fornecedorFiltro.DtCadastro;

                    if (!string.IsNullOrWhiteSpace(fornecedorFiltro.Documento))
                        command.Parameters.Add("@Documento", SqlDbType.NVarChar).Value = fornecedorFiltro.Documento;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            { 
                                Fornecedor fornecedor = new Fornecedor()
                                {
                                    Nome = reader.IsDBNull(0) ? null : reader.GetString(0),
                                    Documento = reader.IsDBNull(1) ? null : reader.GetString(1),
                                    RG = reader.IsDBNull(2) ? null : reader.GetString(2),
                                    DtCadastro = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                                    DtNascimento = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                                    Telefone = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    empresa = EmpresaDD.BuscarEmpresa(fornecedorFiltro.IdEmpresa)
                            };
                                listaFornecedores.Add(fornecedor);
                            }
                        }
                    }
                }

                if (listaFornecedores.Count == 0)
                {
                    Fornecedor fornecedor = new Fornecedor()
                    {
                        empresa = EmpresaDD.BuscarEmpresa(fornecedorFiltro.IdEmpresa)
                    };
                    listaFornecedores.Add(fornecedor);
                }
                return listaFornecedores;
            }
            catch 
            {
                throw new ApplicationException("Não foram encontrados dados válidos");
            }
        }

        public static Fornecedor BuscarFornecedor(int idFornecedor)
        {
            try
            {

                Fornecedor fornecedor = new Fornecedor();

                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-O734NVQ\\SQLEXPRESS;Database=SistemaEmpresa;Trusted_Connection=True;"))
                {

                    SqlCommand command = new SqlCommand("[dbo].[buscar_fornecedor]", connection);
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@idFornecedor", idFornecedor == 0 ? idFornecedor = 1 : idFornecedor);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                fornecedor.Nome = reader.IsDBNull(0) ? null : reader.GetString(0);
                                fornecedor.Documento = reader.IsDBNull(1) ? null : reader.GetString(1);
                                fornecedor.RG = reader.IsDBNull(2) ? null : reader.GetString(2);
                                fornecedor.DtCadastro = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);
                                fornecedor.DtNascimento = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4);
                                fornecedor.Telefone = reader.IsDBNull(5) ? null : reader.GetString(5);
                            }
                        }
                        else
                        {
                            throw new ApplicationException("Fornecedor não encontrado.");
                        }
                    }
                }

                return fornecedor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
