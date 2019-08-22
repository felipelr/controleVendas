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
    public class ContaBancariaDAO : IBaseDAO<ContaBancaria>
    {
        public void Alterar(ContaBancaria model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE ContaBancaria SET descricao = @descricao, agencia = @agencia, conta = @conta WHERE idContaBancaria = @idContaBancaria";

                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);
                    cmd.Parameters.AddWithValue("@agencia", model.Agencia);
                    cmd.Parameters.AddWithValue("@conta", model.Conta);
                    cmd.Parameters.AddWithValue("@idContaBancaria", model.IdContaBancaria);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(ContaBancaria model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE ContaBancaria SET ativo = 0 WHERE idContaBancaria = @idContaBancaria";

                    cmd.Parameters.AddWithValue("@idContaBancaria", model.IdContaBancaria);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ContaBancaria Inserir(ContaBancaria model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO ContaBancaria (descricao, agencia, conta, ativo) VALUES (@descricao, @agencia, @conta, 1); SELECT @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);
                    cmd.Parameters.AddWithValue("@agencia", model.Agencia);
                    cmd.Parameters.AddWithValue("@conta", model.Conta);

                    model.IdContaBancaria = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ContaBancaria ListarPorId(long id)
        {
            SqlConnection conn = null;
            try
            {
                ContaBancaria model = null;
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM ContaBancaria WHERE idContaBancaria = @idContaBancaria;";

                    cmd.Parameters.AddWithValue("@idContaBancaria", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model = new ContaBancaria()
                            {
                                IdContaBancaria = Convert.ToInt32(reader["idContaBancaria"]),
                                Descricao = reader["descricao"].ToString(),
                                Conta = reader["conta"].ToString(),
                                Agencia = reader["agencia"].ToString(),
                                Ativo = Convert.ToInt32(reader["ativo"])
                            };
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

        public List<ContaBancaria> ListarTodos(string where)
        {
            SqlConnection conn = null;
            try
            {
                List<ContaBancaria> lista = new List<ContaBancaria>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM ContaBancaria WHERE ativo = 1 " + where;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ContaBancaria model = new ContaBancaria()
                            {
                                IdContaBancaria = Convert.ToInt32(reader["idContaBancaria"]),
                                Descricao = reader["descricao"].ToString(),
                                Conta = reader["conta"].ToString(),
                                Agencia = reader["agencia"].ToString(),
                                Ativo = Convert.ToInt32(reader["ativo"])
                            };

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
