using ControleVendasDAO.Interfaces;
using ControleVendasModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasDAO
{
    public class ContaMovimentacaoDAO : IBaseDAO<ContaMovimentacao>
    {
        public void Alterar(ContaMovimentacao model)
        {
            throw new NotImplementedException();
        }

        public void Excluir(ContaMovimentacao model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM ContaMovimentacao WHERE idContaMovimentacao = @idContaMovimentacao";

                    cmd.Parameters.AddWithValue("@idContaMovimentacao", model.IdContaMovimentacao);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ContaMovimentacao Inserir(ContaMovimentacao model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO ContaMovimentacao (descricao, valor, dataMovimentacao, tipoMovimentacao, idContaBancaria) 
                        VALUES (@descricao, @valor, @dataMovimentacao, @tipoMovimentacao, @idContaBancaria); SELECT @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);
                    cmd.Parameters.AddWithValue("@valor", model.Valor);
                    cmd.Parameters.AddWithValue("@dataMovimentacao", model.DataMovimentacao);
                    cmd.Parameters.AddWithValue("@tipoMovimentacao", model.TipoMovimentacao);
                    cmd.Parameters.AddWithValue("@idContaBancaria", model.ContaBancaria.IdContaBancaria);

                    model.IdContaMovimentacao = Convert.ToInt64(cmd.ExecuteScalar());
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ContaMovimentacao ListarPorId(long id)
        {
            SqlConnection conn = null;
            try
            {
                ContaMovimentacao model = null;
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT CM.*, C.descricao as descConta, C.agencia, C.conta
                        FROM ContaMovimentacao AS CM 
                        INNER JOIN ContaBancaria AS C ON (CM.idContaBancaria = C.idContaBancaria)
                        WHERE CM.idContaMovimentacao = @idContaMovimentacao;";

                    cmd.Parameters.AddWithValue("@idContaMovimentacao", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model = new ContaMovimentacao()
                            {
                                IdContaMovimentacao = Convert.ToInt64(reader["idContaMovimentacao"]),
                                Descricao = reader["descricao"].ToString(),
                                Valor = Convert.ToDecimal(reader["valor"]),
                                DataMovimentacao = Convert.ToDateTime(reader["dataMovimentacao"]),
                                TipoMovimentacao = Convert.ToInt32(reader["tipoMovimentacao"])
                            };

                            model.ContaBancaria = new ContaBancaria();
                            model.ContaBancaria.IdContaBancaria = Convert.ToInt32(reader["idContaBancaria"]);
                            model.ContaBancaria.Descricao = reader["descConta"].ToString();
                            model.ContaBancaria.Agencia = reader["agencia"].ToString();
                            model.ContaBancaria.Conta = reader["conta"].ToString();
                        }
                    }
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ContaMovimentacao> ListarTodos(string where)
        {
            SqlConnection conn = null;
            try
            {
                List<ContaMovimentacao> lista = new List<ContaMovimentacao>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT CM.*, C.descricao as descConta, C.agencia, C.conta
                        FROM ContaMovimentacao AS CM 
                        INNER JOIN ContaBancaria AS C ON (CM.idContaBancaria = C.idContaBancaria)
                        WHERE 1 = 1 " + where;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ContaMovimentacao model = new ContaMovimentacao()
                            {
                                IdContaMovimentacao = Convert.ToInt64(reader["idContaMovimentacao"]),
                                Descricao = reader["descricao"].ToString(),
                                Valor = Convert.ToDecimal(reader["valor"]),
                                DataMovimentacao = Convert.ToDateTime(reader["dataMovimentacao"]),
                                TipoMovimentacao = Convert.ToInt32(reader["tipoMovimentacao"])
                            };

                            model.ContaBancaria = new ContaBancaria();
                            model.ContaBancaria.IdContaBancaria = Convert.ToInt32(reader["idContaBancaria"]);
                            model.ContaBancaria.Descricao = reader["descConta"].ToString();
                            model.ContaBancaria.Agencia = reader["agencia"].ToString();
                            model.ContaBancaria.Conta = reader["conta"].ToString();

                            lista.Add(model);
                        }
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
