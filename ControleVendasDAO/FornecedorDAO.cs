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
    public class FornecedorDAO : IBaseDAO<Fornecedor>
    {
        public void Alterar(Fornecedor model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Fornecedor SET nome = @nome WHERE idFornecedor = @idFornecedor";

                    cmd.Parameters.AddWithValue("@nome", model.Nome);
                    cmd.Parameters.AddWithValue("@idFornecedor", model.IdFornecedor);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Fornecedor model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Fornecedor SET ativo = 0 WHERE idFornecedor = @idFornecedor";

                    cmd.Parameters.AddWithValue("@idFornecedor", model.IdFornecedor);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Fornecedor Inserir(Fornecedor model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Fornecedor (nome, ativo) VALUES (@nome, 1); SELECT @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@nome", model.Nome);

                    model.IdFornecedor = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Fornecedor ListarPorId(long id)
        {
            SqlConnection conn = null;
            try
            {
                Fornecedor model = null;
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Fornecedor WHERE idFornecedor = @idFornecedor;";

                    cmd.Parameters.AddWithValue("@idFornecedor", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model = new Fornecedor()
                            {
                                IdFornecedor = Convert.ToInt32(reader["idFornecedor"]),
                                Nome = reader["nome"].ToString(),
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

        public List<Fornecedor> ListarTodos(string where)
        {
            SqlConnection conn = null;
            try
            {
                List<Fornecedor> lista = new List<Fornecedor>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Fornecedor WHERE ativo = 1 " + where;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fornecedor model = new Fornecedor()
                            {
                                IdFornecedor = Convert.ToInt32(reader["idFornecedor"]),
                                Nome = reader["nome"].ToString(),
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
