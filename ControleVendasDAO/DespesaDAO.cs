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
    public class DespesaDAO : IBaseDAO<Despesa>
    {
        public void Alterar(Despesa model)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Despesa model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM Despesa WHERE idDespesa = @idDespesa";

                    cmd.Parameters.AddWithValue("@idDespesa", model.IdDespesa);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Despesa Inserir(Despesa model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO Despesa (descricao, valor, dataDespesa, idCategoriaDespesa, idFornecedor, status) 
                        VALUES (@descricao, @valor, @dataDespesa, @idCategoria, @idFornecedor, @status); SELECT @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);
                    cmd.Parameters.AddWithValue("@valor", model.Valor);
                    cmd.Parameters.AddWithValue("@dataDespesa", model.DataDespesa);
                    cmd.Parameters.AddWithValue("@idCategoria", model.Categoria.IdCategoriaDespesa);
                    cmd.Parameters.AddWithValue("@status", model.Status);

                    if (model.Fornecedor != null && model.Fornecedor.IdFornecedor != 0)
                        cmd.Parameters.AddWithValue("@idFornecedor", model.Fornecedor.IdFornecedor);
                    else
                        cmd.Parameters.AddWithValue("@idFornecedor", DBNull.Value);

                    model.IdDespesa = Convert.ToInt64(cmd.ExecuteScalar());
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Despesa ListarPorId(long id)
        {
            SqlConnection conn = null;
            try
            {
                Despesa model = null;
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT D.*, CD.descricao AS descCategoriaDespesa, F.nome
                        FROM Despesa AS D 
                        INNER JOIN CategoriaDespesa AS CD ON (D.idCategoriaDespesa = CD.idCategoriaDespesa)
                        LEFT JOIN Fornecedor AS F ON (D.idFornecedor = F.idFornecedor)
                        WHERE D.idDespesa = @idDespesa;";

                    cmd.Parameters.AddWithValue("@idDespesa", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model = new Despesa()
                            {
                                IdDespesa = Convert.ToInt64(reader["idDespesa"]),
                                Descricao = reader["descricao"].ToString(),
                                Valor = Convert.ToDecimal(reader["valor"]),
                                DataDespesa = Convert.ToDateTime(reader["dataDespesa"]),
                                Status = Convert.ToInt32(reader["status"])
                            };

                            model.Categoria = new CategoriaDespesa();
                            model.Categoria.IdCategoriaDespesa = Convert.ToInt32(reader["idCategoriaDespesa"]);
                            model.Categoria.Descricao = reader["descCategoriaDespesa"].ToString();

                            if (reader["idFornecedor"].ToString() != "")
                            {
                                model.Fornecedor = new Fornecedor();
                                model.Fornecedor.IdFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                                model.Fornecedor.Nome = reader["nome"].ToString();
                            }
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

        public List<Despesa> ListarTodos(string where)
        {
            SqlConnection conn = null;
            try
            {
                List<Despesa> lista = new List<Despesa>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT D.*, CD.descricao AS descCategoriaDespesa, F.nome
                        FROM Despesa AS D 
                        INNER JOIN CategoriaDespesa AS CD ON (D.idCategoriaDespesa = CD.idCategoriaDespesa)
                        LEFT JOIN Fornecedor AS F ON (D.idFornecedor = F.idFornecedor)
                        WHERE 1 = 1 " + where;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Despesa model = new Despesa()
                            {
                                IdDespesa = Convert.ToInt64(reader["idDespesa"]),
                                Descricao = reader["descricao"].ToString(),
                                Valor = Convert.ToDecimal(reader["valor"]),
                                DataDespesa = Convert.ToDateTime(reader["dataDespesa"]),
                                Status = Convert.ToInt32(reader["status"])
                            };

                            model.Categoria = new CategoriaDespesa();
                            model.Categoria.IdCategoriaDespesa = Convert.ToInt32(reader["idCategoriaDespesa"]);
                            model.Categoria.Descricao = reader["descCategoriaDespesa"].ToString();

                            if (reader["idFornecedor"].ToString() != "")
                            {
                                model.Fornecedor = new Fornecedor();
                                model.Fornecedor.IdFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                                model.Fornecedor.Nome = reader["nome"].ToString();
                            }

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

        public void PagarDespesa(long idDespesa)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Despesa SET status = 1 WHERE idDespesa = @idDespesa";

                    cmd.Parameters.AddWithValue("@idDespesa", idDespesa);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
