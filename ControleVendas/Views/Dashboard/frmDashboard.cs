using ControleVendas.Util;
using ControleVendas.Views.Cadastros;
using ControleVendas.Views.ContaBancariaMovimento;
using ControleVendas.Views.ContasPagar;
using ControleVendas.Views.Movimentacoes;
using ControleVendasController;
using ControleVendasModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.Views.Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CarregarVendas();
            CarregarHistoricoProdutos();
            try
            {
                cmbTiposMovimento.DataSource = new ProdutoController().ListarTiposHistorico();
                cmbTiposMovimento.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUnidadeCadastro().Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMarcaCadastro().Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmProdutoCadastro().Show();
        }

        private void btnRegistrarVendas_Click(object sender, EventArgs e)
        {
            new frmVenda().Show();
        }

        private void btnFinalizarSessao_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

        public void CarregarVendas()
        {
            List<Venda> lista = null;
            try
            {
                string whereDatas = " AND CAST(V.dataInicio AS DATE) BETWEEN CAST('" + dtpVendaInicio.Value.ToString("yyyy-MM-dd") + "' AS DATE) AND CAST('" + dtpVendaTermino.Value.ToString("yyyy-MM-dd") + "' AS DATE) ";
                lista = new VendaController().ListarTodos(" AND V.status = " + Venda.STATUS_FINALIZADO + whereDatas);
            }
            catch
            {
            }

            dgvVendas.Rows.Clear();
            dgvVendasTotal.Rows.Clear();
            if (lista != null)
            {
                decimal qtdeTotal = 0m, custoTotal = 0m, valorTotal = 0m, lucroTotal = 0m;
                foreach (Venda Venda in lista)
                {
                    dgvVendas.Rows.Add(Venda.IdVenda,
                        Venda.DataInicio,
                        Venda.QuantidadeTotal,
                        Venda.CustoTotal,
                        Venda.ValorTotal,
                        Venda.LucroTotal,
                        String.Format("{0:N2} %", Venda.MargemLucro),
                        Properties.Resources.ic_buscar_preto_24,
                        Properties.Resources.ic_excluir_preto_24);

                    qtdeTotal += Venda.QuantidadeTotal;
                    custoTotal += Venda.CustoTotal;
                    valorTotal += Venda.ValorTotal;
                    lucroTotal += Venda.LucroTotal;
                }

                decimal margemLucro = ((valorTotal - custoTotal) * 100) / (custoTotal == 0 ? 1 : custoTotal);
                
                dgvVendasTotal.Rows.Add("",
                    "TOTAL",
                    qtdeTotal,
                    custoTotal,
                    valorTotal,
                    lucroTotal,
                    String.Format("{0:N2} %", margemLucro),
                    Properties.Resources.ic_empty_24,
                    Properties.Resources.ic_empty_24);

                dgvVendasTotal.ClearSelection();
                dgvVendas.ClearSelection();
            }
        }

        public void CarregarHistoricoProdutos()
        {
            List<HistoricoMovimentacaoProduto> lista = null;
            try
            {
                string where = " AND CAST(dataAlteracao AS DATE) BETWEEN CAST('" + dtpHistoricoInicio.Value.ToString("yyyy-MM-dd") + "' AS DATE) AND CAST('" + dtpHistoricoTermino.Value.ToString("yyyy-MM-dd") + "' AS DATE) ";
                if (cmbTiposMovimento.SelectedIndex != -1 && cmbTiposMovimento.Text != "")
                    where += " AND observacao = '" + (cmbTiposMovimento.SelectedItem as String) + "' ";

                lista = new ProdutoController().HistoricoMovimentacaoProdutos(where);
            }
            catch
            {
            }

            dgvMovimentacoesProdutos.Rows.Clear();
            if (lista != null)
            {
                foreach (HistoricoMovimentacaoProduto historico in lista)
                {
                    dgvMovimentacoesProdutos.Rows.Add(historico.Produto.IdProduto,
                        historico.Produto.GetDescricaoCompleta(),
                        historico.QuantidadeSaida,
                        historico.QuantidadeEntrada,
                        historico.EstoqueAtual);
                }
                dgvMovimentacoesProdutos.ClearSelection();
            }
        }

        private void btnAtualizarSaidas_Click(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void btnAtualizarMovimentacoes_Click(object sender, EventArgs e)
        {
            CarregarHistoricoProdutos();
        }

        private void dgvSaidasProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 4)
                {
                    try
                    {
                        long idVenda = Convert.ToInt64(dgvVendas.Rows[e.RowIndex].Cells["CellIdVenda"].Value);
                        Venda Venda = new VendaController().ListarPorId(idVenda);
                        new frmVendaDetalhes(Venda).ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível localizar a venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (e.ColumnIndex == 5)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Deseja realmente cancelar esta venda?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            return;
                        }

                        long idVenda = Convert.ToInt64(dgvVendas.Rows[e.RowIndex].Cells["CellIdVenda"].Value);
                        Venda Venda = new VendaController().ListarPorId(idVenda);
                        new VendaController().Excluir(Venda);
                        dgvVendas.Rows.RemoveAt(e.RowIndex);
                        CarregarHistoricoProdutos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível excluir a venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmbTiposMovimento_Click(object sender, EventArgs e)
        {
            try
            {
                cmbTiposMovimento.DataSource = new ProdutoController().ListarTiposHistorico();
                cmbTiposMovimento.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void despesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCategoriaDespesaCadastro().Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFornecedorCadastro().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmDespesas().Show();
        }

        private void contaBancáriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmContaBancariaCadastro().Show();
        }

        private void btnRegistrarMovimentoConta_Click(object sender, EventArgs e)
        {
            new frmContaBancariaMovimentacao().Show();
        }
    }
}
