using ControleVendas.Util;
using ControleVendas.Views.Dashboard;
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

namespace ControleVendas.Views.Movimentacoes
{
    public partial class frmVenda : Form
    {
        private bool IsLoading = true;


        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            try
            {
                cmbProduto.DataSource = new ProdutoController().ListarTodos("");
                cmbProduto.DisplayMember = "IdProduto";
                cmbProduto.DisplayMember = "Descricao";
                cmbProduto.SelectedIndex = -1;
            }
            catch
            {
            }
            IsLoading = false;
        }

        private void txtIdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Tools.IsNumeric(txtIdProduto.Text))
                {
                    try
                    {
                        Produto produto = new ProdutoController().ListarPorId(Convert.ToInt64(txtIdProduto.Text));
                        if (produto != null)
                        {
                            cmbProduto.SelectedIndex = cmbProduto.FindString(produto.Descricao);
                            txtQuantidade.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Produto não localizado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.IsLoading && cmbProduto.SelectedIndex != -1 && !string.IsNullOrEmpty(cmbProduto.Text))
            {
                Produto produto = cmbProduto.SelectedItem as Produto;
                txtIdProduto.Text = produto.IdProduto.ToString();
                txtPrecoVenda.Text = produto.PrecoVenda.ToString("N2");
                lblEstoqueAtual.Text = produto.Estoque.ToString("N2") + " " + produto.Unidade.Descricao;
            }
        }

        private void cmbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuantidade.Focus();
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            Tools.TextBoxMoeda(sender as TextBox);
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrecoVenda.Focus();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedIndex == -1 || string.IsNullOrEmpty(cmbProduto.Text))
            {
                MessageBox.Show("Informe o produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Tools.IsNumeric(txtQuantidade.Text))
            {
                MessageBox.Show("Informe a quantidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (Convert.ToDecimal(txtQuantidade.Text) <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior do que 0.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Tools.IsNumeric(txtPrecoVenda.Text))
            {
                MessageBox.Show("Informe o valor unitário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (Convert.ToDecimal(txtPrecoVenda.Text) < 0)
            {
                MessageBox.Show("O Preço de Venda deve ser maior ou igual 0.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Produto produto = cmbProduto.SelectedItem as Produto;
            decimal quantidade = Convert.ToDecimal(txtQuantidade.Text);
            decimal precoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
            decimal valorTotal = quantidade * precoVenda;

            if (!ValidarProdutoGrid(produto.IdProduto))
            {
                MessageBox.Show("Este produto já foi inserido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantidade > produto.Estoque)
            {
                DialogResult result = MessageBox.Show("A quantidade informada é maior do que o Estoque Atual.\nDeseja continuar mesmo assim?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            dgvMovimentacoesProdutos.Rows.Add(produto.IdProduto,
                produto.GetDescricaoCompleta(),
                quantidade.ToString("N2"),
                precoVenda.ToString("C2"),
                valorTotal.ToString("C2"),
                Properties.Resources.ic_excluir_preto_24);

            dgvMovimentacoesProdutos.ClearSelection();
            LimparDetalhes();
            CalcularTotais();
        }

        private void LimparDetalhes()
        {
            cmbProduto.Text = "";
            cmbProduto.SelectedIndex = -1;
            txtIdProduto.Text = "";
            txtQuantidade.Text = "";
            txtPrecoVenda.Text = "";
            lblEstoqueAtual.Text = "-";
            txtIdProduto.Focus();
        }

        private bool ValidarProdutoGrid(long idProduto)
        {
            bool isValid = true;
            if (dgvMovimentacoesProdutos.Rows.Count > 0)
            {
                for (int i = 0; i < dgvMovimentacoesProdutos.Rows.Count; i++)
                {
                    if (idProduto == Convert.ToInt64(dgvMovimentacoesProdutos.Rows[i].Cells["CellIdProduto"].Value))
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            return isValid;
        }

        private void CalcularTotais()
        {
            decimal quantidadeTotal = 0m;
            decimal valorTotal = 0m;
            if (dgvMovimentacoesProdutos.Rows.Count > 0)
            {
                for (int i = 0; i < dgvMovimentacoesProdutos.Rows.Count; i++)
                {
                    quantidadeTotal += Convert.ToDecimal(dgvMovimentacoesProdutos.Rows[i].Cells["CellQuantidadeMovimentacao"].Value);
                    valorTotal += Convert.ToDecimal(dgvMovimentacoesProdutos.Rows[i].Cells["CellValorTotalMovimentacao"].Value.ToString().Replace("R$", "").Trim());
                }
            }

            lblTotalQuantidade.Text = quantidadeTotal.ToString("N2");
            lblTotalValor.Text = valorTotal.ToString("C2");
        }

        private void dgvMovimentacoesProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DialogResult result = MessageBox.Show("Deseja realmente remover este item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dgvMovimentacoesProdutos.Rows.RemoveAt(e.RowIndex);
                        CalcularTotais();
                    }
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvMovimentacoesProdutos.Rows.Count == 0)
            {
                MessageBox.Show("Insira pelo menos 1 produto para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Venda venda = new Venda();
            venda.DataInicio = DateTime.Now;
            venda.DataTermino = DateTime.Now;
            venda.Status = Venda.STATUS_FINALIZADO;
            venda.QuantidadeTotal = Convert.ToDecimal(lblTotalQuantidade.Text);
            venda.ValorTotal = Convert.ToDecimal(lblTotalValor.Text.Replace("R$", "").Trim());

            venda.Itens = new List<Vendatem>();
            ProdutoController produtoController = new ProdutoController();

            for (int i = 0; i < dgvMovimentacoesProdutos.Rows.Count; i++)
            {
                Produto produto = null;
                try
                {
                    produto = produtoController.ListarPorId(Convert.ToInt64(dgvMovimentacoesProdutos.Rows[i].Cells["CellIdProduto"].Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas ao localizar produtos: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Vendatem item = new Vendatem();
                item.Produto = produto;
                item.Custo = item.Produto.Custo;
                item.Quantidade = Convert.ToDecimal(dgvMovimentacoesProdutos.Rows[i].Cells["CellQuantidadeMovimentacao"].Value);
                item.ValorUnitario = Convert.ToDecimal(dgvMovimentacoesProdutos.Rows[i].Cells["CellValorUnitario"].Value.ToString().Replace("R$", "").Trim());
                item.ValorTotal = Convert.ToDecimal(dgvMovimentacoesProdutos.Rows[i].Cells["CellValorTotalMovimentacao"].Value.ToString().Replace("R$", "").Trim());
                item.CustoTotal = item.Custo * item.Quantidade;

                venda.Itens.Add(item);
            }

            try
            {
                venda = new VendaController().Inserir(venda);
                dgvMovimentacoesProdutos.Rows.Clear();
                LimparDetalhes();
                MessageBox.Show("Venda Finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                try
                {
                    Form form = Application.OpenForms["frmDashboard"];
                    if (form != null)
                    {
                        frmDashboard frmDashboard = (frmDashboard)form;
                        frmDashboard.CarregarVendas();
                        frmDashboard.CarregarHistoricoProdutos();
                    }
                }
                catch
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao registrar saída de produtos: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            Tools.TextBoxMoeda(sender as TextBox);
        }

        private void txtPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInserir.PerformClick();
            }
        }
    }
}
