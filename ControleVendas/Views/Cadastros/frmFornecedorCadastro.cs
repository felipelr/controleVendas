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
    public partial class frmFornecedorCadastro : Form
    {
        private Fornecedor Fornecedor = null;

        public frmFornecedorCadastro()
        {
            InitializeComponent();
        }

        private void frmFornecedorCadastro_Load(object sender, EventArgs e)
        {
            LimparDetalhes();
            BuscarFornecedors();
            txtNome.Focus();
            txtNome.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFornecedors();
        }

        private void BuscarFornecedors()
        {
            string where = "";
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (Tools.IsNumeric(txtBuscar.Text))
                    where = " AND idFornecedor = " + txtBuscar.Text + " ";
                else
                    where = " AND nome LIKE '%" + txtBuscar.Text + "%' ";
            }

            List<Fornecedor> lista = null;

            try
            {
                lista = new FornecedorController().ListarTodos(where);
            }
            catch
            {
            }

            dgvFornecedores.Rows.Clear();

            if (lista != null)
            {
                foreach (Fornecedor Fornecedor in lista)
                {
                    dgvFornecedores.Rows.Add(Fornecedor.IdFornecedor,
                        Fornecedor.Nome,
                        Properties.Resources.ic_edit_preto_24,
                        Properties.Resources.ic_excluir_preto_24);
                }
                dgvFornecedores.ClearSelection();
            }
        }

        private void PreencherDetalhes()
        {
            txtIdFornecedor.Text = this.Fornecedor.IdFornecedor.ToString();
            txtNome.Text = this.Fornecedor.Nome;
        }

        private void LimparDetalhes()
        {
            this.Fornecedor = null;
            this.txtIdFornecedor.Text = "";
            this.txtNome.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Informe o nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.Fornecedor == null)
            {
                this.Fornecedor = new Fornecedor();
                this.Fornecedor.Nome = txtNome.Text.Trim();

                try
                {
                    this.Fornecedor = new FornecedorController().Inserir(this.Fornecedor);
                    LimparDetalhes();
                    BuscarFornecedors();
                }
                catch (Exception ex)
                {
                    this.Fornecedor = null;
                    MessageBox.Show("Problemas o inserir Fornecedor: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.Fornecedor.Nome = txtNome.Text;

                try
                {
                    new FornecedorController().Alterar(this.Fornecedor);
                    LimparDetalhes();
                    BuscarFornecedors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas o alterar Fornecedor: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparDetalhes();
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 2)
                {
                    try
                    {
                        long id = Convert.ToInt64(dgvFornecedores.Rows[e.RowIndex].Cells["CellIdFornecedor"].Value);
                        this.Fornecedor = new FornecedorController().ListarPorId(id);
                        PreencherDetalhes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o buscar Fornecedor: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Deseja realmente exlcuir este item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(dgvFornecedores.Rows[e.RowIndex].Cells["CellIdFornecedor"].Value);
                            this.Fornecedor = new Fornecedor() { IdFornecedor = id };
                            new FornecedorController().Excluir(this.Fornecedor);
                            LimparDetalhes();
                            BuscarFornecedors();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o excluir Fornecedor: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
