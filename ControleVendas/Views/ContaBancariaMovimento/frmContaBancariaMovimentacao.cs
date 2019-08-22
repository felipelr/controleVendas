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

namespace ControleVendas.Views.ContaBancariaMovimento
{
    public partial class frmContaBancariaMovimentacao : Form
    {
        private string descricao = "";
        private int tipo = 2;
        private DateTime dataDe = Tools.PrimeiroDiadoMes(DateTime.Now);
        private DateTime dataAte = Tools.UltimoDiadoMes(DateTime.Now);
        private List<ContaListItem> listaContas = new List<ContaListItem>();

        public frmContaBancariaMovimentacao()
        {
            InitializeComponent();
        }

        private void frmContaBancariaMovimentacao_Load(object sender, EventArgs e)
        {
            LimparDetalhes();
            BuscarContaMovimentacoes();

            cmbConta.DataSource = new ContaBancariaController().ListarTodos("");
            cmbConta.ValueMember = "IdContaBancaria";
            cmbConta.DisplayMember = "ContaCombo";
            cmbConta.SelectedIndex = -1;

            txtDescricao.Focus();
            txtDescricao.Select();
        }

        private void BuscarContaMovimentacoes()
        {
            string where = " AND CAST(CM.dataMovimentacao AS DATE) BETWEEN CAST('" + this.dataDe.ToString("yyyy-MM-dd") + "' AS DATE) AND CAST('" + this.dataAte.ToString("yyyy-MM-dd") + "' AS DATE) ";

            if (!string.IsNullOrEmpty(this.descricao))
            {
                where += " AND CM.descricao LIKE '%" + this.descricao.Trim() + "%' ";
            }

            if (this.tipo != 2)
            {
                where += " AND CM.tipoMovimentacao = " + this.tipo;
            }

            if (this.listaContas.Count > 0)
            {
                string ids = "";
                foreach (ContaListItem item in this.listaContas)
                {
                    ids += item.IdContaBancaria + ",";
                }
                ids = ids.Substring(0, ids.Length - 1);
                where += " AND CM.idContaBancaria IN (" + ids + ") ";
            }

            List<ContaMovimentacao> lista = null;

            try
            {
                lista = new ContaMovimentacaoController().ListarTodos(where);
            }
            catch
            {
            }

            dgvMovimentacoes.Rows.Clear();
            decimal totalSaldo = 0m;
            decimal totalEntrada = 0m;
            decimal totalSaida = 0m;

            if (lista != null)
            {
                foreach (ContaMovimentacao contaMovimentacao in lista)
                {
                    dgvMovimentacoes.Rows.Add(contaMovimentacao.IdContaMovimentacao,
                        contaMovimentacao.DataMovimentacao,
                        contaMovimentacao.Descricao,
                        contaMovimentacao.ContaBancaria.ContaCombo,
                        contaMovimentacao.Valor,
                        contaMovimentacao.TipoMovimentacao == ContaMovimentacao.TIPO_ENTRADA ? "E" : "S",
                        Properties.Resources.ic_excluir_preto_24);                    

                    if (contaMovimentacao.TipoMovimentacao == ContaMovimentacao.TIPO_ENTRADA)
                        totalEntrada += contaMovimentacao.Valor;
                    else
                        totalSaida += contaMovimentacao.Valor;
                }
                dgvMovimentacoes.ClearSelection();
            }
            totalSaldo = totalEntrada - totalSaida;

            lblTotalEntradas.Text = totalEntrada.ToString("C2");
            lblTotalSaidas.Text = totalSaida.ToString("C2");
            lblSaldo.Text = totalSaldo.ToString("C2");
        }

        private void LimparDetalhes()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
            cmbConta.SelectedIndex = -1;
            dtpDataMovimentacao.Value = DateTime.Now;
            rbtTipoEntrada.Checked = true;
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbConta.Focus();
            }
        }

        private void cmbConta_KeyDown(object sender, KeyEventArgs e)
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
                dtpDataMovimentacao.Focus();
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
                MessageBox.Show("Informe uma descrição para a movimentação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmbConta.SelectedIndex == -1 || string.IsNullOrEmpty(cmbConta.Text))
            {
                MessageBox.Show("Informe a conta bancária da movimentação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Tools.IsNumeric(txtValor.Text))
            {
                MessageBox.Show("Informe o valor da movimentação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ContaMovimentacao ContaMovimentacao = new ContaMovimentacao();
            ContaMovimentacao.Descricao = txtDescricao.Text.Trim();
            ContaMovimentacao.ContaBancaria = cmbConta.SelectedItem as ContaBancaria;
            ContaMovimentacao.Valor = Convert.ToDecimal(txtValor.Text);
            ContaMovimentacao.DataMovimentacao = dtpDataMovimentacao.Value;
            ContaMovimentacao.TipoMovimentacao = rbtTipoEntrada.Checked ? ContaMovimentacao.TIPO_ENTRADA : ContaMovimentacao.TIPO_SAIDA;
            

            try
            {
                ContaMovimentacao = new ContaMovimentacaoController().Inserir(ContaMovimentacao);
                LimparDetalhes();
                BuscarContaMovimentacoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir movimentação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparDetalhes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmContaBancariaMovimentacaoFiltros filtros = new frmContaBancariaMovimentacaoFiltros(this.descricao, this.tipo, this.dataDe, this.dataAte, this.listaContas);
            filtros.ShowDialog();

            this.descricao = filtros.GetDescricao();
            this.tipo = filtros.GetTipo();
            this.dataDe = filtros.GetDataDe();
            this.dataAte = filtros.GetDataAte();
            this.listaContas = filtros.GetListaContas();

            BuscarContaMovimentacoes();
        }

        private void dgvMovimentacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult yesNo = MessageBox.Show("Deseja realmente excluir esta movimentação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (yesNo == DialogResult.Yes)
                    {
                        try
                        {
                            ContaMovimentacao ContaMovimentacao = new ContaMovimentacao() { IdContaMovimentacao = Convert.ToInt64(dgvMovimentacoes.Rows[e.RowIndex].Cells["CellIdContaMovimentacao"].Value) };
                            new ContaMovimentacaoController().Excluir(ContaMovimentacao);
                            BuscarContaMovimentacoes();
                            MessageBox.Show("Movimentação excluída com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possível excluir a movimentação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
