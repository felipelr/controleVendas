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
    public class VendaDAO : IBaseDAO<Venda>
    {
        public void Alterar(Venda model)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Venda model)
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
                        cmd.CommandText = @"UPDATE Venda SET status = @status WHERE idVenda = @idVenda;";

                        cmd.Parameters.AddWithValue("@idVenda", model.IdVenda);
                        cmd.Parameters.AddWithValue("@status", Venda.STATUS_CANCELADO);

                        model.IdVenda = Convert.ToInt64(cmd.ExecuteScalar());

                        foreach (Vendatem item in model.Itens)
                        {
                            item.Venda = new Venda() { IdVenda = model.IdVenda };                            

                            string observacao = "Cancelamento de Venda";

                            cmd.CommandText = @"UPDATE Produto SET estoque = @estoqueNovo WHERE idProduto = @idProduto;
                                INSERT INTO EstoqueMovimentacao (idProduto, estoque, estoqueNovo, custo, custoNovo, precoVenda, precoVendaNovo, observacao, dataAlteracao) 
                                VALUES (@idProduto, @estoque, @estoqueNovo, @custo, @custoNovo, @precoVenda, @precoVendaNovo, @observacao, GETDATE()); ";

                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idProduto", item.Produto.IdProduto);
                            cmd.Parameters.AddWithValue("@observacao", observacao);

                            cmd.Parameters.AddWithValue("@estoque", item.Produto.Estoque);
                            cmd.Parameters.AddWithValue("@precoVenda", item.Produto.PrecoVenda);
                            cmd.Parameters.AddWithValue("@precoVendaNovo", item.Produto.PrecoVenda);

                            cmd.Parameters.AddWithValue("@estoqueNovo", item.Produto.Estoque + item.Quantidade);
                            cmd.Parameters.AddWithValue("@custo", item.Produto.Custo);
                            cmd.Parameters.AddWithValue("@custoNovo", item.Produto.Custo);

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

        public Venda Inserir(Venda model)
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
                        cmd.CommandText = @"INSERT INTO Venda (quantidadeTotal, valorTotal, dataInicio, dataTermino, status)
                            VALUES (@quantidadeTotal, @valorTotal, @dataInicio, @dataTermino, @status); SELECT @@IDENTITY;";

                        cmd.Parameters.AddWithValue("@quantidadeTotal", model.QuantidadeTotal);
                        cmd.Parameters.AddWithValue("@valorTotal", model.ValorTotal);
                        cmd.Parameters.AddWithValue("@dataInicio", model.DataInicio);
                        cmd.Parameters.AddWithValue("@dataTermino", model.DataTermino);
                        cmd.Parameters.AddWithValue("@status", model.Status);

                        model.IdVenda = Convert.ToInt64(cmd.ExecuteScalar());

                        foreach (Vendatem item in model.Itens)
                        {
                            item.Venda = new Venda() { IdVenda = model.IdVenda };

                            cmd.CommandText = @"INSERT INTO VendaItem (idProduto, idVenda, quantidade, valorUnitario, valorTotal, custo, custoTotal)
                            VALUES (@idProduto, @idVenda, @quantidade, @valorUnitario, @valorTotal, @custo, @custoTotal); SELECT @@IDENTITY;";

                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idProduto", item.Produto.IdProduto);
                            cmd.Parameters.AddWithValue("@idVenda", item.Venda.IdVenda);
                            cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                            cmd.Parameters.AddWithValue("@valorUnitario", item.ValorUnitario);
                            cmd.Parameters.AddWithValue("@valorTotal", item.ValorTotal);
                            cmd.Parameters.AddWithValue("@custo", item.Custo);
                            cmd.Parameters.AddWithValue("@custoTotal", item.CustoTotal);

                            item.IdVendaItem = Convert.ToInt64(cmd.ExecuteScalar());

                            string observacao = "Venda";

                            cmd.CommandText = @"UPDATE Produto SET estoque = @estoqueNovo WHERE idProduto = @idProduto;
                                INSERT INTO EstoqueMovimentacao (idProduto, estoque, estoqueNovo, custo, custoNovo, precoVenda, precoVendaNovo, observacao, dataAlteracao) 
                                VALUES (@idProduto, @estoque, @estoqueNovo, @custo, @custoNovo, @precoVenda, @precoVendaNovo, @observacao, GETDATE()); ";

                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idProduto", item.Produto.IdProduto);
                            cmd.Parameters.AddWithValue("@observacao", observacao);

                            cmd.Parameters.AddWithValue("@estoque", item.Produto.Estoque);
                            cmd.Parameters.AddWithValue("@precoVenda", item.Produto.PrecoVenda);
                            cmd.Parameters.AddWithValue("@precoVendaNovo", item.Produto.PrecoVenda);

                            cmd.Parameters.AddWithValue("@estoqueNovo", item.Produto.Estoque - item.Quantidade);
                            cmd.Parameters.AddWithValue("@custo", item.Produto.Custo);
                            cmd.Parameters.AddWithValue("@custoNovo", item.Produto.Custo);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        return model;
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

        public Venda ListarPorId(long id)
        {
            SqlConnection conn = null;
            try
            {
                Venda Venda = new Venda();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT SP.*, SPI.idVendaItem, SPI.quantidade AS quantidadeItem, SPI.valorUnitario AS valorUnitarioItem, SPI.valorTotal AS valorTotalItem,
                        SPI.custo, SPI.custoTotal,
                        P.idProduto, P.descricao AS produtoDesc, U.idUnidade, U.descricao AS unidadeDesc, 
                        M.idMarca, M.descricao AS marcaDesc
                        FROM Venda AS SP 
                        INNER JOIN VendaItem AS SPI ON (SP.idVenda = SPI.idVenda)
                        INNER JOIN Produto AS P ON (SPI.idProduto = P.idProduto)
                        INNER JOIN Unidade AS U ON (P.idUnidade = U.idUnidade)
                        INNER JOIN Marca AS M ON (P.idMarca = M.idMarca)
                        WHERE SP.idVenda = @idVenda; ";
                    cmd.Parameters.AddWithValue("@idVenda", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool firstRow = true;

                        while (reader.Read())
                        {
                            if (firstRow)
                            {
                                firstRow = false;

                                Venda.IdVenda = Convert.ToInt64(reader["idVenda"]);
                                Venda.DataInicio = Convert.ToDateTime(reader["dataInicio"]);
                                Venda.Status = Convert.ToInt32(reader["status"]);
                                Venda.QuantidadeTotal = Convert.ToDecimal(reader["quantidadeTotal"]);
                                Venda.ValorTotal = Convert.ToDecimal(reader["valorTotal"]);

                                if (reader["dataTermino"].ToString() != "")
                                    Venda.DataTermino = Convert.ToDateTime(reader["dataTermino"]);

                                Venda.Itens = new List<Vendatem>();
                            }

                            Vendatem item = new Vendatem();
                            item.Produto = new Produto();
                            item.IdVendaItem = Convert.ToInt64(reader["idVendaItem"]);
                            item.Produto.IdProduto = Convert.ToInt64(reader["idProduto"]);
                            item.Produto.Descricao = reader["produtoDesc"].ToString();

                            item.Produto.Unidade = new Unidade();
                            item.Produto.Unidade.IdUnidade = Convert.ToInt32(reader["idUnidade"]);
                            item.Produto.Unidade.Descricao = reader["unidadeDesc"].ToString();

                            item.Produto.Marca = new Marca();
                            item.Produto.Marca.IdMarca = Convert.ToInt32(reader["idMarca"]);
                            item.Produto.Marca.Descricao = reader["marcaDesc"].ToString();

                            item.Quantidade = Convert.ToDecimal(reader["quantidadeItem"]);
                            item.ValorUnitario = Convert.ToDecimal(reader["valorUnitarioItem"]);
                            item.ValorTotal = Convert.ToDecimal(reader["valorTotalItem"]);
                            item.Custo = Convert.ToDecimal(reader["custo"]);
                            item.CustoTotal = Convert.ToDecimal(reader["custoTotal"]);
                            item.Venda = new Venda();
                            item.Venda.IdVenda = id;

                            Venda.Itens.Add(item);
                        }
                    }
                }

                return Venda;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Venda> ListarTodos(string where)
        {
            SqlConnection conn = null;
            try
            {
                List<Venda> lista = new List<Venda>();

                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT V.*, SUM(VI.custo * VI.quantidade) AS custoTotal
                        FROM Venda AS V 
                        INNER JOIN VendaItem AS VI ON (V.idVenda = VI.idVenda)
                        WHERE 1 = 1 " + where + @"
                        GROUP BY V.idVenda, V.quantidadeTotal, V.valorTotal, V.dataInicio, V.dataTermino, V.status ";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venda Venda = new Venda();
                            Venda.IdVenda = Convert.ToInt64(reader["idVenda"]);
                            Venda.DataInicio = Convert.ToDateTime(reader["dataInicio"]);
                            Venda.Status = Convert.ToInt32(reader["status"]);
                            Venda.QuantidadeTotal = Convert.ToDecimal(reader["quantidadeTotal"]);
                            Venda.ValorTotal = Convert.ToDecimal(reader["valorTotal"]);
                            Venda.CustoTotal = Convert.ToDecimal(reader["custoTotal"]);
                            Venda.LucroTotal = Venda.ValorTotal - Venda.CustoTotal;
                            Venda.MargemLucro = ((Venda.ValorTotal - Venda.CustoTotal) * 100) / (Venda.CustoTotal == 0 ? 1 : Venda.CustoTotal);

                            if (reader["dataTermino"].ToString() != "")
                                Venda.DataTermino = Convert.ToDateTime(reader["dataTermino"]);

                            lista.Add(Venda);
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
