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

namespace ControleVendas.Views.Cadastros
{
    public partial class frmContaBancariaCadastro : Form
    {
        private ContaBancaria ContaBancaria = null;

        public frmContaBancariaCadastro()
        {
            InitializeComponent();
        }

        private void frmContaBancariaCadastro_Load(object sender, EventArgs e)
        {
            LimparDetalhes();
            BuscarContaBancarias();
            txtDescricao.Focus();
            txtDescricao.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarContaBancarias();
        }

        private void BuscarContaBancarias()
        {
            string where = "";
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (Tools.IsNumeric(txtBuscar.Text))
                    where = " AND idContaBancaria = " + txtBuscar.Text + " ";

                where = " OR descricao LIKE '%" + txtBuscar.Text + "%' ";
                where = " OR agencia LIKE '%" + txtBuscar.Text + "%' ";
                where = " OR conta LIKE '%" + txtBuscar.Text + "%' ";
            }

            List<ContaBancaria> lista = null;

            try
            {
                lista = new ContaBancariaController().ListarTodos(where);
            }
            catch
            {
            }

            dgvContas.Rows.Clear();

            if (lista != null)
            {
                foreach (ContaBancaria conta in lista)
                {
                    dgvContas.Rows.Add(conta.IdContaBancaria,
                        conta.Descricao,
                        conta.Agencia,
                        conta.Conta,
                        Properties.Resources.ic_edit_preto_24,
                        Properties.Resources.ic_excluir_preto_24);
                }
                dgvContas.ClearSelection();
            }
        }

        private void PreencherDetalhes()
        {
            txtIdContaBancaria.Text = this.ContaBancaria.IdContaBancaria.ToString();
            txtDescricao.Text = this.ContaBancaria.Descricao;
            txtAgencia.Text = this.ContaBancaria.Agencia;
            txtConta.Text = this.ContaBancaria.Conta;
        }

        private void LimparDetalhes()
        {
            this.ContaBancaria = null;
            this.txtIdContaBancaria.Text = "";
            this.txtDescricao.Text = "";
            this.txtAgencia.Text = "";
            this.txtConta.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtAgencia.Text))
            {
                MessageBox.Show("Informe a agência.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtConta.Text))
            {
                MessageBox.Show("Informe a conta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.ContaBancaria == null)
            {
                this.ContaBancaria = new ContaBancaria();
                this.ContaBancaria.Descricao = txtDescricao.Text.Trim();
                this.ContaBancaria.Agencia = txtAgencia.Text.Trim();
                this.ContaBancaria.Conta = txtConta.Text.Trim();

                try
                {
                    this.ContaBancaria = new ContaBancariaController().Inserir(this.ContaBancaria);
                    LimparDetalhes();
                    BuscarContaBancarias();
                }
                catch (Exception ex)
                {
                    this.ContaBancaria = null;
                    MessageBox.Show("Problemas o inserir Conta Bancária: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.ContaBancaria.Descricao = txtDescricao.Text.Trim();
                this.ContaBancaria.Agencia = txtAgencia.Text.Trim();
                this.ContaBancaria.Conta = txtConta.Text.Trim();

                try
                {
                    new ContaBancariaController().Alterar(this.ContaBancaria);
                    LimparDetalhes();
                    BuscarContaBancarias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas o alterar Conta Bancária: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparDetalhes();
        }

        private void dgvContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 4)
                {
                    try
                    {
                        long id = Convert.ToInt64(dgvContas.Rows[e.RowIndex].Cells["CellIdContaBancaria"].Value);
                        this.ContaBancaria = new ContaBancariaController().ListarPorId(id);
                        PreencherDetalhes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o buscar Conta Bancária: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (e.ColumnIndex == 5)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Deseja realmente exlcuir este item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(dgvContas.Rows[e.RowIndex].Cells["CellIdContaBancaria"].Value);
                            this.ContaBancaria = new ContaBancaria() { IdContaBancaria = id };
                            new ContaBancariaController().Excluir(this.ContaBancaria);
                            LimparDetalhes();
                            BuscarContaBancarias();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o excluir Conta Bancária: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
