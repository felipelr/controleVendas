using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasDAO
{
    public class ConfiguracaoDAO
    {
        public string VerificarBancoDados()
        {
            SqlConnection conn = null;
            try
            {
                string status = "";
                using (conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Produto";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        status = "SUCESSO";
                    }
                }

                return status;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InicializarBancoDados()
        {
            try
            {
                //criar database
                using (SqlConnection conn = new SqlConnection(Conexao.Conexao.StringConexaoMaster))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"
                        IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'ControleVendas')
                        CREATE DATABASE [ControleVendas]
                        ";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Produto";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //teste
                    }
                }
            }
            catch
            {
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexao.Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    SqlTransaction transaction = conn.BeginTransaction("SampleTransaction");

                    cmd.Connection = conn;
                    cmd.Transaction = transaction;

                    try
                    {
                        //criar tabelas
                        cmd.CommandText = @"
                            USE [ControleVendas];

                            CREATE TABLE [dbo].[CategoriaDespesa](
	                            [idCategoriaDespesa] [int] IDENTITY(1,1) NOT NULL,
	                            [descricao] [varchar](max) NULL,
	                            [ativo] [int] NULL,
                             CONSTRAINT [PK_CategoriaDespesa] PRIMARY KEY CLUSTERED 
                            (
	                            [idCategoriaDespesa] ASC
                            )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
                            ) ON [PRIMARY];

                            CREATE TABLE [dbo].[ContaBancaria](
	                            [idContaBancaria] [int] IDENTITY(1,1) NOT NULL,
	                            [descricao] [varchar](max) NULL,
	                            [agencia] [varchar](50) NULL,
	                            [conta] [varchar](50) NULL,
	                            [ativo] [int] NULL,
                             CONSTRAINT [PK_ContaBancaria] PRIMARY KEY CLUSTERED 
                            (
	                            [idContaBancaria] ASC
                            )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
                            ) ON [PRIMARY];

                            CREATE TABLE [dbo].[Fornecedor](
	                            [idFornecedor] [int] IDENTITY(1,1) NOT NULL,
	                            [nome] [varchar](max) NULL,
	                            [ativo] [int] NULL,
                             CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
                            (
	                            [idFornecedor] ASC
                            )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
                            ) ON [PRIMARY];

                            CREATE TABLE [dbo].[Despesa](
	                            [idDespesa] [bigint] IDENTITY(1,1) NOT NULL,
	                            [descricao] [varchar](max) NULL,
	                            [valor] [money] NULL,
	                            [dataDespesa] [datetime] NULL,
	                            [idCategoriaDespesa] [int] NULL,
	                            [idFornecedor] [int] NULL,
	                            [status] [int] NULL,
                             CONSTRAINT [PK_Despesa] PRIMARY KEY CLUSTERED 
                            (
	                            [idDespesa] ASC
                            )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
                            ) ON [PRIMARY];

                            SET ANSI_PADDING OFF;

                            ALTER TABLE [dbo].[Despesa]  WITH CHECK ADD  CONSTRAINT [FK_Despesa_idCategoriaDespesa] FOREIGN KEY([idCategoriaDespesa])
                            REFERENCES [dbo].[CategoriaDespesa] ([idCategoriaDespesa]);

                            ALTER TABLE [dbo].[Despesa] CHECK CONSTRAINT [FK_Despesa_idCategoriaDespesa];

                            ALTER TABLE [dbo].[Despesa]  WITH CHECK ADD  CONSTRAINT [FK_Despesa_idFornecedor] FOREIGN KEY([idFornecedor])
                            REFERENCES [dbo].[Fornecedor] ([idFornecedor]);

                            ALTER TABLE [dbo].[Despesa] CHECK CONSTRAINT [FK_Despesa_idFornecedor];

                            CREATE TABLE [dbo].[Marca](
	                            [idMarca] [int] IDENTITY(1,1) NOT NULL,
	                            [descricao] [varchar](max) NULL,
	                            [ativo] [int] NULL,
                             CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
                            (
	                            [idMarca] ASC
                            )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
                            ) ON [PRIMARY];

                            CREATE TABLE [dbo].[Unidade](
	                            [idUnidade] [int] IDENTITY(1,1) NOT NULL,
	                            [descricao] [varchar](max) NULL,
	                            [ativo] [int] NULL,
                             CONSTRAINT [PK_Unidade] PRIMARY KEY CLUSTERED 
                            (
	                            [idUnidade] ASC
                            )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
                            ) ON [PRIMARY];

                            CREATE TABLE [dbo].[Produto](
	                            [idProduto] [bigint] NOT NULL,
	                            [descricao] [varchar](max) NULL,
	                            [idUnidade] [int] NULL,
	                            [idMarca] [int] NULL,
	                            [estoque] [money] NULL,
	                            [custo] [money] NULL,
	                            [precoVenda] [money] NULL,
	                            [ativo] [int] NULL,
                             CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
                            (
	                            [idProduto] ASC
                            )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
                            ) ON [PRIMARY];

                            SET ANSI_PADDING OFF;

                            ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_idMarca] FOREIGN KEY([idMarca])
                            REFERENCES [dbo].[Marca] ([idMarca]);

                            ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_idMarca];

                            ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_idUnidade] FOREIGN KEY([idUnidade])
                            REFERENCES [dbo].[Unidade] ([idUnidade]);

                            ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_idUnidade];


                            CREATE TABLE [dbo].[EstoqueMovimentacao](
	                            [idProduto] [bigint] NULL,
	                            [estoque] [money] NULL,
	                            [estoqueNovo] [money] NULL,
	                            [custo] [money] NULL,
	                            [custoNovo] [money] NULL,
	                            [precoVenda] [money] NULL,
	                            [precoVendaNovo] [money] NULL,
	                            [observacao] [varchar](max) NULL,
	                            [dataAlteracao] [datetime] NULL
                            ) ON [PRIMARY];

                            SET ANSI_PADDING OFF;

                            ALTER TABLE [dbo].[EstoqueMovimentacao]  WITH CHECK ADD  CONSTRAINT [FK_EstoqueMovimentacao_idProduto] FOREIGN KEY([idProduto])
                            REFERENCES [dbo].[Produto] ([idProduto]);

                            ALTER TABLE [dbo].[EstoqueMovimentacao] CHECK CONSTRAINT [FK_EstoqueMovimentacao_idProduto];

                            CREATE TABLE [dbo].[Venda](
	                            [idVenda] [bigint] IDENTITY(1,1) NOT NULL,
	                            [quantidadeTotal] [money] NULL,
	                            [valorTotal] [money] NULL,
	                            [dataInicio] [datetime] NULL,
	                            [dataTermino] [datetime] NULL,
	                            [status] [int] NULL,
                             CONSTRAINT [PK_SaidaProduto] PRIMARY KEY CLUSTERED 
                            (
	                            [idVenda] ASC
                            )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
                            ) ON [PRIMARY];

                            CREATE TABLE [dbo].[VendaItem](
	                            [idVendaItem] [bigint] IDENTITY(1,1) NOT NULL,
	                            [idVenda] [bigint] NULL,
	                            [idProduto] [bigint] NULL,
	                            [quantidade] [money] NULL,
	                            [valorUnitario] [money] NULL,
	                            [valorTotal] [money] NULL,
	                            [custo] [money] NULL,
	                            [custoTotal] [money] NULL,
                             CONSTRAINT [PK_SaidaProdutoItem] PRIMARY KEY CLUSTERED 
                            (
	                            [idVendaItem] ASC
                            )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
                            ) ON [PRIMARY];

                            ALTER TABLE [dbo].[VendaItem]  WITH CHECK ADD  CONSTRAINT [FK_VendaItem_idProduto] FOREIGN KEY([idProduto])
                            REFERENCES [dbo].[Produto] ([idProduto]);

                            ALTER TABLE [dbo].[VendaItem] CHECK CONSTRAINT [FK_VendaItem_idProduto];

                            ALTER TABLE [dbo].[VendaItem]  WITH CHECK ADD  CONSTRAINT [FK_VendaItem_idVenda] FOREIGN KEY([idVenda])
                            REFERENCES [dbo].[Venda] ([idVenda]);

                            ALTER TABLE [dbo].[VendaItem] CHECK CONSTRAINT [FK_VendaItem_idVenda];

                            CREATE TABLE [dbo].[ContaMovimentacao](
	                            [idContaMovimentacao] [bigint] IDENTITY(1,1) NOT NULL,
	                            [idContaBancaria] [int] NULL,
	                            [descricao] [varchar](max) NULL,
	                            [valor] [money] NULL,
	                            [tipoMovimentacao] [int] NULL,
	                            [dataMovimentacao] [datetime] NULL,
                             CONSTRAINT [PK_ContaMovimentacao] PRIMARY KEY CLUSTERED 
                            (
	                            [idContaMovimentacao] ASC
                            )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
                            ) ON [PRIMARY];

                            SET ANSI_PADDING OFF;

                            ALTER TABLE [dbo].[ContaMovimentacao]  WITH CHECK ADD  CONSTRAINT [FK_ContaMovimentacao_idContaBancaria] FOREIGN KEY([idContaBancaria])
                            REFERENCES [dbo].[ContaBancaria] ([idContaBancaria]);

                            ALTER TABLE [dbo].[ContaMovimentacao] CHECK CONSTRAINT [FK_ContaMovimentacao_idContaBancaria];
                        ";

                        cmd.ExecuteNonQuery();

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
    }
}
