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
    public class UnidadeDAO : IBaseDAO<Unidade>
    {
        public void Alterar(Unidade model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Unidade SET descricao = @descricao WHERE idUnidade = @idUnidade";

                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);
                    cmd.Parameters.AddWithValue("@idUnidade", model.IdUnidade);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Unidade model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Unidade SET ativo = 0 WHERE idUnidade = @idUnidade";

                    cmd.Parameters.AddWithValue("@idUnidade", model.IdUnidade);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Unidade Inserir(Unidade model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Unidade (descricao, ativo) VALUES (@descricao, 1); SELECT @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);

                    model.IdUnidade = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Unidade ListarPorId(long id)
        {
            SqlConnection conn = null;
            try
            {
                Unidade model = null;
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Unidade WHERE idUnidade = @idUnidade;";

                    cmd.Parameters.AddWithValue("@idUnidade", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model = new Unidade()
                            {
                                IdUnidade = Convert.ToInt32(reader["idUnidade"]),
                                Descricao = reader["descricao"].ToString(),
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

        public List<Unidade> ListarTodos(string where)
        {
            SqlConnection conn = null;
            try
            {
                List<Unidade> lista = new List<Unidade>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Unidade WHERE ativo = 1 " + where;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Unidade model = new Unidade()
                            {
                                IdUnidade = Convert.ToInt32(reader["idUnidade"]),
                                Descricao = reader["descricao"].ToString(),
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
