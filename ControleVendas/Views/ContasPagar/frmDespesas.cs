using ControleVendas.Util;
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

namespace ControleVendas.Views.ContasPagar
{
    public partial class frmDespesas : Form
    {
        private string descricao = "";
        private int pago = 2;
        private DateTime dataDe = Tools.PrimeiroDiadoMes(DateTime.Now);
        private DateTime dataAte = Tools.UltimoDiadoMes(DateTime.Now);
        private List<CatDespListItem> listaCategorias = new List<CatDespListItem>();
        private List<FornListItem> listaFornecedores = new List<FornListItem>();

        public frmDespesas()
        {
            InitializeComponent();
        }

        private void frmDespesas_Load(object sender, EventArgs e)
        {
            LimparDetalhes();
            BuscarDespesas();

            cmbCategoria.DataSource = new CategoriaDespesaController().ListarTodos("");
            cmbCategoria.ValueMember = "IdCategoriaDespesa";
            cmbCategoria.DisplayMember = "Descricao";
            cmbCategoria.SelectedIndex = -1;

            cmbFornecedor.DataSource = new FornecedorController().ListarTodos("");
            cmbFornecedor.ValueMember = "IdFornecedor";
            cmbFornecedor.DisplayMember = "Nome";
            cmbFornecedor.SelectedIndex = -1;

            txtDescricao.Focus();
            txtDescricao.Select();
        }

        private void BuscarDespesas()
        {
            string where = " AND CAST(D.dataDespesa AS DATE) BETWEEN CAST('" + this.dataDe.ToString("yyyy-MM-dd") + "' AS DATE) AND CAST('" + this.dataAte.ToString("yyyy-MM-dd") + "' AS DATE) ";

            if (!string.IsNullOrEmpty(this.descricao))
            {
                where += " AND D.descricao LIKE '%" + this.descricao.Trim() + "%' ";
            }

            if (this.pago != 2)
            {
                where += " AND D.status = " + this.pago;
            }

            if (this.listaCategorias.Count > 0)
            {
                string ids = "";
                foreach (CatDespListItem item in this.listaCategorias)
                {
                    ids += item.IdCategoriaDespesa + ",";
                }
                ids = ids.Substring(0, ids.Length - 1);
                where += " AND D.idCategoriaDespesa IN (" + ids + ") ";
            }

            if (this.listaFornecedores.Count > 0)
            {
                string ids = "";
                foreach (FornListItem item in this.listaFornecedores)
                {
                    ids += item.IdFornecedor + ",";
                }
                ids = ids.Substring(0, ids.Length - 1);
                where += " AND D.idFornecedor IN (" + ids + ") ";
            }

            List<Despesa> lista = null;

            try
            {
                lista = new DespesaController().ListarTodos(where);
            }
            catch
            {
            }

            dgvDespesas.Rows.Clear();
            decimal totalDespesas = 0m;
            decimal totalDespesasPagas = 0m;
            decimal totalDespesasNaoPagas = 0m;

            if (lista != null)
            {
                foreach (Despesa despesa in lista)
                {
                    dgvDespesas.Rows.Add(despesa.IdDespesa,
                        despesa.DataDespesa,
                        despesa.Descricao,
                        despesa.Categoria.Descricao,
                        despesa.Fornecedor != null ? despesa.Fornecedor.Nome : "",
                        despesa.Valor,
                        despesa.Status == 1 ? Properties.Resources.ic_empty_24 : Properties.Resources.ic_dollar_preto_24,
                        Properties.Resources.ic_excluir_preto_24,
                        despesa.Status);

                    if (despesa.Status == 0)
                        dgvDespesas.Rows[dgvDespesas.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.FromArgb(244, 67, 54);

                    totalDespesas += despesa.Valor;
                    if (despesa.Status == 0)
                        totalDespesasNaoPagas += despesa.Valor;
                    else
                        totalDespesasPagas += despesa.Valor;
                }
                dgvDespesas.ClearSelection();
            }
            lblTotalDespesasGeral.Text = totalDespesas.ToString("C2");
            lblTotalDespesasNaoPagas.Text = totalDespesasNaoPagas.ToString("C2");
            lblTotalDespesasPagas.Text = totalDespesasPagas.ToString("C2");
        }

        private void LimparDetalhes()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
            cmbCategoria.SelectedIndex = -1;
            cmbFornecedor.SelectedIndex = -1;
            dtpDataDespesa.Value = DateTime.Now;
            rbtPagaSim.Checked = true;
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbFornecedor.Focus();
            }
        }

        private void cmbFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCategoria.Focus();
            }
        }

        private void cmbCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValor.Focus();
            }
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpDataDespesa.Focus();
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            Tools.TextBoxMoeda(sender as TextBox);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe uma descrição para a despesa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmbCategoria.SelectedIndex == -1 || string.IsNullOrEmpty(cmbCategoria.Text))
            {
                MessageBox.Show("Informe a categoria da despesa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Tools.IsNumeric(txtValor.Text))
            {
                MessageBox.Show("Informe o valor da despesa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Despesa despesa = new Despesa();
            despesa.Descricao = txtDescricao.Text.Trim();
            despesa.Categoria = cmbCategoria.SelectedItem as CategoriaDespesa;
            despesa.Valor = Convert.ToDecimal(txtValor.Text);
            despesa.DataDespesa = dtpDataDespesa.Value;
            despesa.Status = rbtPagaSim.Checked ? 1 : 0;
            if (cmbFornecedor.SelectedIndex != -1 && !string.IsNullOrEmpty(cmbFornecedor.Text))
            {
                despesa.Fornecedor = cmbFornecedor.SelectedItem as Fornecedor;
            }

            try
            {
                despesa = new DespesaController().Inserir(despesa);
                LimparDetalhes();
                BuscarDespesas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir despesa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparDetalhes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDespesaFiltros filtros = new frmDespesaFiltros(this.descricao, this.pago, this.dataDe, this.dataAte, this.listaCategorias, this.listaFornecedores);
            filtros.ShowDialog();

            this.descricao = filtros.GetDescricao();
            this.pago = filtros.GetPago();
            this.dataDe = filtros.getDataDe();
            this.dataAte = filtros.getDataAte();
            this.listaCategorias = filtros.GetListaCategorias();
            this.listaFornecedores = filtros.GetListaFornecedores();

            BuscarDespesas();
        }

        private void dgvDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 6)
                {
                    if (Convert.ToInt32(dgvDespesas.Rows[e.RowIndex].Cells["CellStatus"].Value) == 0)
                    {
                        DialogResult yesNo = MessageBox.Show("Deseja realmente pagar esta despesa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (yesNo == DialogResult.Yes)
                        {
                            try
                            {
                                long idDespesa = Convert.ToInt64(dgvDespesas.Rows[e.RowIndex].Cells["CellIdDespesa"].Value);
                                new DespesaController().PagarDespesa(idDespesa);
                                BuscarDespesas();
                                MessageBox.Show("Desepesa paga com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Não foi possível pagar a despesa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                else if (e.ColumnIndex == 7)
                {
                    DialogResult yesNo = MessageBox.Show("Deseja realmente excluir esta despesa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (yesNo == DialogResult.Yes)
                    {
                        try
                        {
                            Despesa despesa = new Despesa() { IdDespesa = Convert.ToInt64(dgvDespesas.Rows[e.RowIndex].Cells["CellIdDespesa"].Value) };
                            new DespesaController().Excluir(despesa);
                            BuscarDespesas();
                            MessageBox.Show("Desepesa excluída com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possível excluir a despesa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
