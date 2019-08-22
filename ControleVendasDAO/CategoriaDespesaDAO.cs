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
    public class CategoriaDespesaDAO : IBaseDAO<CategoriaDespesa>
    {
        public void Alterar(CategoriaDespesa model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE CategoriaDespesa SET descricao = @descricao WHERE idCategoriaDespesa = @idCategoriaDespesa";

                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);
                    cmd.Parameters.AddWithValue("@idCategoriaDespesa", model.IdCategoriaDespesa);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(CategoriaDespesa model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE CategoriaDespesa SET ativo = 0 WHERE idCategoriaDespesa = @idCategoriaDespesa";

                    cmd.Parameters.AddWithValue("@idCategoriaDespesa", model.IdCategoriaDespesa);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CategoriaDespesa Inserir(CategoriaDespesa model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO CategoriaDespesa (descricao, ativo) VALUES (@descricao, 1); SELECT @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);

                    model.IdCategoriaDespesa = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CategoriaDespesa ListarPorId(long id)
        {
            SqlConnection conn = null;
            try
            {
                CategoriaDespesa model = null;
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM CategoriaDespesa WHERE idCategoriaDespesa = @idCategoriaDespesa;";

                    cmd.Parameters.AddWithValue("@idCategoriaDespesa", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model = new CategoriaDespesa()
                            {
                                IdCategoriaDespesa = Convert.ToInt32(reader["idCategoriaDespesa"]),
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

        public List<CategoriaDespesa> ListarTodos(string where)
        {
            SqlConnection conn = null;
            try
            {
                List<CategoriaDespesa> lista = new List<CategoriaDespesa>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM CategoriaDespesa WHERE ativo = 1 " + where;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CategoriaDespesa model = new CategoriaDespesa()
                            {
                                IdCategoriaDespesa = Convert.ToInt32(reader["idCategoriaDespesa"]),
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
