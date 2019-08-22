using ControleVendasModel;
using ControleVendasController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleVendas.Util;

namespace ControleVendas.Views.Cadastros
{
    public partial class frmProdutoCadastro : Form
    {
        private Produto Produto = null;

        public frmProdutoCadastro()
        {
            InitializeComponent();
        }

        private void frmProdutoCadastro_Load(object sender, EventArgs e)
        {
            LimparDetalhes();
            BuscarProdutos();

            try
            {
                cmbUnidade.DataSource = new UnidadeController().ListarTodos("");
                cmbUnidade.DisplayMember = "IdUnidade";
                cmbUnidade.DisplayMember = "Descricao";
                cmbUnidade.SelectedIndex = -1;
            }
            catch
            {
            }

            try
            {
                cmbMarca.DataSource = new MarcaController().ListarTodos("");
                cmbMarca.DisplayMember = "IdMarca";
                cmbMarca.DisplayMember = "Descricao";
                cmbMarca.SelectedIndex = -1;
            }
            catch
            {
            }


            txtDescricao.Focus();
            txtDescricao.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProdutos();
        }

        private void BuscarProdutos()
        {
            string where = "";
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (rbtProduto.Checked)
                {
                    if (Tools.IsNumeric(txtBuscar.Text))
                        where = " AND P.idProduto = " + txtBuscar.Text + " ";
                    else
                        where = " AND P.descricao LIKE '%" + txtBuscar.Text + "%' ";
                }
                else if (rbtUnidade.Checked)
                {
                    if (Tools.IsNumeric(txtBuscar.Text))
                        where = " AND U.idUnidade = " + txtBuscar.Text + " ";
                    else
                        where = " AND U.descricao LIKE '%" + txtBuscar.Text + "%' ";
                }
                else if (rbtMarca.Checked)
                {
                    if (Tools.IsNumeric(txtBuscar.Text))
                        where = " AND M.idMarca = " + txtBuscar.Text + " ";
                    else
                        where = " AND M.descricao LIKE '%" + txtBuscar.Text + "%' ";
                }
            }

            List<Produto> lista = null;

            try
            {
                lista = new ProdutoController().ListarTodos(where);
            }
            catch
            {
            }

            dgvProdutos.Rows.Clear();
            if (lista != null)
            {
                foreach (Produto produto in lista)
                {
                    dgvProdutos.Rows.Add(produto.IdProduto,
                        produto.GetDescricaoCompleta(),
                        produto.Estoque.ToString("N2"),
                        Properties.Resources.ic_edit_preto_24,
                        Properties.Resources.ic_excluir_preto_24);
                }
                dgvProdutos.ClearSelection();
            }
        }

        private void PreencherDetalhes()
        {
            txtIdProduto.Text = this.Produto.IdProduto.ToString();
            txtDescricao.Text = this.Produto.Descricao;
            txtEstoque.Text = this.Produto.Estoque.ToString("N2");
            txtCusto.Text = this.Produto.Custo.ToString("N2");
            txtPrecoVenda.Text = this.Produto.PrecoVenda.ToString("N2");
            decimal margem = ((this.Produto.PrecoVenda - this.Produto.Custo) * 100) / (this.Produto.Custo == 0 ? 1 : this.Produto.Custo);
            txtMargemLucro.Text = margem < 0 ? "0,00" : margem.ToString("N2");
            cmbUnidade.SelectedIndex = cmbUnidade.FindString(this.Produto.Unidade.Descricao);
            cmbMarca.SelectedIndex = cmbMarca.FindString(this.Produto.Marca.Descricao);
        }

        private void LimparDetalhes()
        {
            this.Produto = null;
            try
            {
                this.txtIdProduto.Text = new ProdutoController().ProximoId().ToString();
            }
            catch
            {
                this.txtIdProduto.Text = "1";
            }

            this.txtDescricao.Text = "";
            txtEstoque.Text = (0m).ToString("N2");
            txtCusto.Text = (0m).ToString("N2");
            txtPrecoVenda.Text = (0m).ToString("N2");
            txtMargemLucro.Text = (0m).ToString("N2");
            cmbUnidade.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProduto.Text))
            {
                MessageBox.Show("Informe o código do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbUnidade.Text) || cmbUnidade.SelectedIndex == -1)
            {
                MessageBox.Show("Informe a unidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbMarca.Text) || cmbMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Informe a marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtEstoque.Text))
            {
                MessageBox.Show("Informe o estoque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtCusto.Text))
            {
                MessageBox.Show("Informe o custo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                MessageBox.Show("Informe o preço de venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.Produto == null)
            {
                this.Produto = new Produto();
                this.Produto.IdProduto = Convert.ToInt64(txtIdProduto.Text);
                this.Produto.Descricao = txtDescricao.Text.Trim();
                this.Produto.Unidade = cmbUnidade.SelectedItem as Unidade;
                this.Produto.Marca = cmbMarca.SelectedItem as Marca;
                this.Produto.Custo = Convert.ToDecimal(txtCusto.Text);
                this.Produto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                this.Produto.Estoque = Convert.ToDecimal(txtEstoque.Text);

                try
                {
                    this.Produto = new ProdutoController().Inserir(this.Produto);
                    LimparDetalhes();
                    BuscarProdutos();
                }
                catch (Exception ex)
                {
                    this.Produto = null;
                    MessageBox.Show("Problemas o inserir Produto: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.Produto.Descricao = txtDescricao.Text.Trim();
                this.Produto.Unidade = cmbUnidade.SelectedItem as Unidade;
                this.Produto.Marca = cmbMarca.SelectedItem as Marca;
                this.Produto.Custo = Convert.ToDecimal(txtCusto.Text);
                this.Produto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                this.Produto.Estoque = Convert.ToDecimal(txtEstoque.Text);

                try
                {
                    new ProdutoController().Alterar(this.Produto);
                    LimparDetalhes();
                    BuscarProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas o alterar produto: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparDetalhes();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 3)
                {
                    try
                    {
                        long id = Convert.ToInt64(dgvProdutos.Rows[e.RowIndex].Cells["CellIdProduto"].Value);
                        this.Produto = new ProdutoController().ListarPorId(id);
                        PreencherDetalhes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o buscar produto: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (e.ColumnIndex == 4)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Deseja realmente exlcuir este item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells["CellIdProduto"].Value);
                            this.Produto = new Produto() { IdProduto = id };
                            new ProdutoController().Excluir(this.Produto);
                            LimparDetalhes();
                            BuscarProdutos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o excluir produto: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnAddEstoque_Click(object sender, EventArgs e)
        {
            frmEstoqueAlterar estoqueAlterar = new frmEstoqueAlterar("Informe a quantidade que deseja inserir");
            estoqueAlterar.ShowDialog(this);

            string strQuantidade = estoqueAlterar.GetStrQuantidade();

            if (Tools.IsNumeric(strQuantidade))
            {
                decimal estoque = Convert.ToDecimal(txtEstoque.Text);
                decimal quantidade = Convert.ToDecimal(strQuantidade);
                estoque += quantidade;

                txtEstoque.Text = estoque.ToString("N2");
            }
        }

        private void btnRemoverEstoque_Click(object sender, EventArgs e)
        {
            frmEstoqueAlterar estoqueAlterar = new frmEstoqueAlterar("Informe a quantidade que deseja remover");
            estoqueAlterar.ShowDialog(this);

            string strQuantidade = estoqueAlterar.GetStrQuantidade();

            if (Tools.IsNumeric(strQuantidade))
            {
                decimal estoque = Convert.ToDecimal(txtEstoque.Text);
                decimal quantidade = Convert.ToDecimal(strQuantidade);
                estoque -= quantidade;

                txtEstoque.Text = estoque.ToString("N2");
            }
        }

        private void txtCusto_TextChanged(object sender, EventArgs e)
        {
            Tools.TextBoxMoeda(sender as TextBox);
            if (txtCusto.Focused)
            {
                decimal precoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                decimal custo = Convert.ToDecimal(txtCusto.Text);
                decimal margem = ((precoVenda - custo) * 100) / (custo == 0 ? 1 : custo);
                txtMargemLucro.Text = margem < 0 ? "0,00" : margem.ToString("N2");
            }
        }

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            Tools.TextBoxMoeda(sender as TextBox);
            if (txtPrecoVenda.Focused)
            {
                decimal precoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                decimal custo = Convert.ToDecimal(txtCusto.Text);
                decimal margem = ((precoVenda - custo) * 100) / (custo == 0 ? 1 : custo);
                txtMargemLucro.Text = margem < 0 ? "0,00" : margem.ToString("N2");
            }
        }

        private void txtIdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                new frmUnidadeCadastro().ShowDialog();
                cmbUnidade.DataSource = new UnidadeController().ListarTodos("");
                cmbUnidade.DisplayMember = "IdUnidade";
                cmbUnidade.DisplayMember = "Descricao";
                cmbUnidade.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            try
            {
                new frmMarcaCadastro().ShowDialog();
                cmbMarca.DataSource = new MarcaController().ListarTodos("");
                cmbMarca.DisplayMember = "IdMarca";
                cmbMarca.DisplayMember = "Descricao";
                cmbMarca.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void txtMargemLucro_TextChanged(object sender, EventArgs e)
        {
            Tools.TextBoxMoeda(sender as TextBox);
            if (txtMargemLucro.Focused)
            {
                decimal margem = Convert.ToDecimal(txtMargemLucro.Text);
                decimal custo = Convert.ToDecimal(txtCusto.Text);
                decimal precoVenda = custo + ((custo * margem) / 100);
                txtPrecoVenda.Text = precoVenda.ToString("N2");
            }
        }
    }
}
