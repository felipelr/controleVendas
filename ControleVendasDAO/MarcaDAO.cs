using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleVendasDAO.Interfaces;
using ControleVendasModel;

namespace ControleVendasDAO
{
    public class MarcaDAO : IBaseDAO<Marca>
    {
        public void Alterar(Marca model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Marca SET descricao = @descricao WHERE idMarca = @idMarca";

                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);
                    cmd.Parameters.AddWithValue("@idMarca", model.IdMarca);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Marca model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Marca SET ativo = 0 WHERE idMarca = @idMarca";

                    cmd.Parameters.AddWithValue("@idMarca", model.IdMarca);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Marca Inserir(Marca model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Marca (descricao, ativo) VALUES (@descricao, 1); SELECT @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);

                    model.IdMarca = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Marca ListarPorId(long id)
        {
            SqlConnection conn = null;
            try
            {
                Marca model = null;
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Marca WHERE idMarca = @idMarca;";

                    cmd.Parameters.AddWithValue("@idMarca", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model = new Marca()
                            {
                                IdMarca = Convert.ToInt32(reader["idMarca"]),
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

        public List<Marca> ListarTodos(string where)
        {
            SqlConnection conn = null;
            try
            {
                List<Marca> lista = new List<Marca>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Marca WHERE ativo = 1 " + where;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Marca model = new Marca()
                            {
                                IdMarca = Convert.ToInt32(reader["idMarca"]),
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
