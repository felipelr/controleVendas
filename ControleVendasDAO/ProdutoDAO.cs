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
    public class ProdutoDAO : IBaseDAO<Produto>
    {
        public void Alterar(Produto model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    SqlTransaction transaction = conn.BeginTransaction("SampleTransaction");

                    cmd.Connection = conn;
                    cmd.Transaction = transaction;

                    try
                    {
                        cmd.CommandText = "SELECT * FROM Produto WHERE idProduto = @idProduto;";
                        cmd.Parameters.AddWithValue("@idProduto", model.IdProduto);

                        Produto produtoOld = new Produto();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                produtoOld.IdProduto = Convert.ToInt64(reader["idProduto"]);
                                produtoOld.Estoque = Convert.ToDecimal(reader["estoque"]);
                                produtoOld.Custo = Convert.ToDecimal(reader["custo"]);
                                produtoOld.PrecoVenda = Convert.ToDecimal(reader["precoVenda"]);
                            }
                        }

                        if (produtoOld.IdProduto == 0)
                            throw new Exception("Produto " + model.IdProduto + " não localizado");

                        cmd.CommandText = @"UPDATE Produto SET descricao = @descricao, idUnidade = @idUnidade, idMarca = @idMarca,
                        estoque = @estoque, custo = @custo, precoVenda = @precoVenda
                        WHERE idProduto = @idProduto;";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@descricao", model.Descricao);
                        cmd.Parameters.AddWithValue("@idUnidade", model.Unidade.IdUnidade);
                        cmd.Parameters.AddWithValue("@idMarca", model.Marca.IdMarca);
                        cmd.Parameters.AddWithValue("@estoque", model.Estoque);
                        cmd.Parameters.AddWithValue("@custo", model.Custo);
                        cmd.Parameters.AddWithValue("@precoVenda", model.PrecoVenda);
                        cmd.Parameters.AddWithValue("@idProduto", model.IdProduto);

                        cmd.ExecuteNonQuery();

                        //verificar se houve alteracao de estoque, preco de venda ou custo
                        if (produtoOld.Estoque != model.Estoque
                            || produtoOld.PrecoVenda != model.PrecoVenda
                            || produtoOld.Custo != model.Custo)
                        {
                            string observacao = "Alteração no";
                            if (produtoOld.Estoque != model.Estoque)
                                observacao += " Estoque,";

                            if (produtoOld.Custo != model.Custo)
                                observacao += " Custo,";

                            if (produtoOld.PrecoVenda != model.PrecoVenda)
                                observacao += " Preco de Venda,";

                            observacao = observacao.Substring(0, observacao.Length - 1);

                            cmd.CommandText = @"INSERT INTO EstoqueMovimentacao (idProduto, estoque, estoqueNovo, custo, custoNovo, precoVenda, precoVendaNovo, observacao, dataAlteracao) 
                                VALUES (@idProduto, @estoque, @estoqueNovo, @custo, @custoNovo, @precoVenda, @precoVendaNovo, @observacao, GETDATE()); ";

                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idProduto", model.IdProduto);
                            cmd.Parameters.AddWithValue("@observacao", observacao);

                            cmd.Parameters.AddWithValue("@estoque", produtoOld.Estoque);
                            cmd.Parameters.AddWithValue("@precoVenda", produtoOld.PrecoVenda);
                            cmd.Parameters.AddWithValue("@precoVendaNovo", model.PrecoVenda);

                            cmd.Parameters.AddWithValue("@estoqueNovo", model.Estoque);
                            cmd.Parameters.AddWithValue("@custo", produtoOld.Custo);
                            cmd.Parameters.AddWithValue("@custoNovo", model.Custo);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Produto model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Produto SET ativo = 0 WHERE idProduto = @idProduto";

                    cmd.Parameters.AddWithValue("@idProduto", model.IdProduto);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Produto Inserir(Produto model)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO Produto (idProduto, descricao, idUnidade, idMarca, estoque, custo, precoVenda, ativo) 
                        VALUES (@idProduto, @descricao, @idUnidade, @idMarca, @estoque, @custo, @precoVenda, 1); ";

                    cmd.Parameters.AddWithValue("@idProduto", model.IdProduto);
                    cmd.Parameters.AddWithValue("@descricao", model.Descricao);
                    cmd.Parameters.AddWithValue("@idUnidade", model.Unidade.IdUnidade);
                    cmd.Parameters.AddWithValue("@idMarca", model.Marca.IdMarca);
                    cmd.Parameters.AddWithValue("@estoque", model.Estoque);
                    cmd.Parameters.AddWithValue("@custo", model.Custo);
                    cmd.Parameters.AddWithValue("@precoVenda", model.PrecoVenda);

                    cmd.ExecuteNonQuery();
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Produto ListarPorId(long id)
        {
            SqlConnection conn = null;
            try
            {
                Produto model = null;
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT P.*, U.descricao AS Udescricao, M.descricao AS Mdescricao
                        FROM Produto AS P 
                        INNER JOIN Unidade AS U ON (P.idUnidade = U.idUnidade)
                        INNER JOIN Marca AS M ON (P.idMarca = M.idMarca)
                        WHERE idProduto = @idProduto;";

                    cmd.Parameters.AddWithValue("@idProduto", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model = new Produto()
                            {
                                IdProduto = Convert.ToInt64(reader["idProduto"]),
                                Descricao = reader["descricao"].ToString(),
                                Estoque = Convert.ToDecimal(reader["estoque"]),
                                PrecoVenda = Convert.ToDecimal(reader["precoVenda"]),
                                Custo = Convert.ToDecimal(reader["custo"]),
                                Ativo = Convert.ToInt32(reader["ativo"])
                            };

                            model.Unidade = new Unidade();
                            model.Unidade.IdUnidade = Convert.ToInt32(reader["idUnidade"]);
                            model.Unidade.Descricao = reader["Udescricao"].ToString();

                            model.Marca = new Marca();
                            model.Marca.IdMarca = Convert.ToInt32(reader["idMarca"]);
                            model.Marca.Descricao = reader["Mdescricao"].ToString();
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

        public List<Produto> ListarTodos(string where)
        {
            SqlConnection conn = null;
            try
            {
                List<Produto> lista = new List<Produto>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT P.*, U.descricao AS Udescricao, M.descricao AS Mdescricao
                        FROM Produto AS P 
                        INNER JOIN Unidade AS U ON (P.idUnidade = U.idUnidade)
                        INNER JOIN Marca AS M ON (P.idMarca = M.idMarca)
                        WHERE P.ativo = 1 " + where;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produto model = new Produto()
                            {
                                IdProduto = Convert.ToInt64(reader["idProduto"]),
                                Descricao = reader["descricao"].ToString(),
                                Estoque = Convert.ToDecimal(reader["estoque"]),
                                PrecoVenda = Convert.ToDecimal(reader["precoVenda"]),
                                Custo = Convert.ToDecimal(reader["custo"]),
                                Ativo = Convert.ToInt32(reader["ativo"])
                            };

                            model.Unidade = new Unidade();
                            model.Unidade.IdUnidade = Convert.ToInt32(reader["idUnidade"]);
                            model.Unidade.Descricao = reader["Udescricao"].ToString();

                            model.Marca = new Marca();
                            model.Marca.IdMarca = Convert.ToInt32(reader["idMarca"]);
                            model.Marca.Descricao = reader["Mdescricao"].ToString();

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

        public long ProximoId()
        {
            SqlConnection conn = null;
            try
            {
                long ultimoId = 1;
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT (MAX(ISNULL(idProduto, 0)) + 1) AS ultimoId FROM Produto;";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ultimoId = Convert.ToInt64(reader["ultimoId"]);
                        }
                    }
                }

                return ultimoId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<HistoricoMovimentacaoProduto> HistoricoMovimentacaoProdutos(string where)
        {
            SqlConnection conn = null;
            try
            {
                List<HistoricoMovimentacaoProduto> lista = new List<HistoricoMovimentacaoProduto>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT X.idProduto, P.descricao, P.estoque, U.descricao AS Udescricao, M.descricao AS Mdescricao, 
                    SUM(quantidadeEntrada) AS quantidadeEntrada, SUM(quantidadeSaida) AS quantidadeSaida 
                    FROM (
	                    SELECT idProduto,
	                    CASE WHEN estoqueNovo < estoque THEN estoque - estoqueNovo ELSE 0 END AS quantidadeSaida,
	                    CASE WHEN estoque < estoqueNovo THEN estoqueNovo - estoque ELSE 0 END AS quantidadeEntrada,
	                    dataAlteracao
	                    FROM EstoqueMovimentacao
	                    WHERE estoqueNovo != estoque " + where + @"
                    ) AS X
                    INNER JOIN Produto AS P ON (X.idProduto = P.idProduto)
                    INNER JOIN Unidade AS U ON (P.idUnidade = U.idUnidade)
                    INNER JOIN Marca AS M ON (P.idMarca = M.idMarca)
                    GROUP BY X.idProduto, P.descricao, P.estoque, U.descricao, M.descricao ";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HistoricoMovimentacaoProduto model = new HistoricoMovimentacaoProduto()
                            {
                                EstoqueAtual = Convert.ToDecimal(reader["estoque"]),
                                QuantidadeEntrada = Convert.ToDecimal(reader["quantidadeEntrada"]),
                                QuantidadeSaida = Convert.ToDecimal(reader["quantidadeSaida"])
                            };

                            model.Produto = new Produto();
                            model.Produto.IdProduto = Convert.ToInt32(reader["idProduto"]);
                            model.Produto.Descricao = reader["descricao"].ToString();
                            model.Produto.Unidade = new Unidade() { Descricao = reader["Udescricao"].ToString() };
                            model.Produto.Marca = new Marca() { Descricao = reader["Mdescricao"].ToString() };

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

        public List<String> ListarTiposHistorico()
        {
            SqlConnection conn = null;
            try
            {
                List<String> lista = new List<String>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT observacao FROM EstoqueMovimentacao WHERE estoqueNovo != estoque GROUP BY observacao;";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String obs = reader["observacao"].ToString();
                            lista.Add(obs);
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
