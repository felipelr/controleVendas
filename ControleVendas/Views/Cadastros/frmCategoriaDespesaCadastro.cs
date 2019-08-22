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
    public partial class frmCategoriaDespesaCadastro : Form
    {
        private CategoriaDespesa CategoriaDespesa = null;

        public frmCategoriaDespesaCadastro()
        {
            InitializeComponent();
        }

        private void frmCategoriaDespesa_Load(object sender, EventArgs e)
        {
            LimparDetalhes();
            BuscarCategoriaDespesas();
            txtDescricao.Focus();
            txtDescricao.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCategoriaDespesas();
        }

        private void BuscarCategoriaDespesas()
        {
            string where = "";
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (Tools.IsNumeric(txtBuscar.Text))
                    where = " AND idCategoriaDespesa = " + txtBuscar.Text + " ";
                else
                    where = " AND descricao LIKE '%" + txtBuscar.Text + "%' ";
            }

            List<CategoriaDespesa> lista = null;

            try
            {
                lista = new CategoriaDespesaController().ListarTodos(where);
            }
            catch
            {
            }

            dgvCategorias.Rows.Clear();

            if (lista != null)
            {
                foreach (CategoriaDespesa CategoriaDespesa in lista)
                {
                    dgvCategorias.Rows.Add(CategoriaDespesa.IdCategoriaDespesa,
                        CategoriaDespesa.Descricao,
                        Properties.Resources.ic_edit_preto_24,
                        Properties.Resources.ic_excluir_preto_24);
                }
                dgvCategorias.ClearSelection();
            }
        }

        private void PreencherDetalhes()
        {
            txtIdCategoriaDespesa.Text = this.CategoriaDespesa.IdCategoriaDespesa.ToString();
            txtDescricao.Text = this.CategoriaDespesa.Descricao;
        }

        private void LimparDetalhes()
        {
            this.CategoriaDespesa = null;
            this.txtIdCategoriaDespesa.Text = "";
            this.txtDescricao.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.CategoriaDespesa == null)
            {
                this.CategoriaDespesa = new CategoriaDespesa();
                this.CategoriaDespesa.Descricao = txtDescricao.Text.Trim();

                try
                {
                    this.CategoriaDespesa = new CategoriaDespesaController().Inserir(this.CategoriaDespesa);
                    LimparDetalhes();
                    BuscarCategoriaDespesas();
                }
                catch (Exception ex)
                {
                    this.CategoriaDespesa = null;
                    MessageBox.Show("Problemas o inserir Categoria de Despesa: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.CategoriaDespesa.Descricao = txtDescricao.Text;

                try
                {
                    new CategoriaDespesaController().Alterar(this.CategoriaDespesa);
                    LimparDetalhes();
                    BuscarCategoriaDespesas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas o alterar Categoria de Despesa: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparDetalhes();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 2)
                {
                    try
                    {
                        long id = Convert.ToInt64(dgvCategorias.Rows[e.RowIndex].Cells["CellIdCategoriaDespesa"].Value);
                        this.CategoriaDespesa = new CategoriaDespesaController().ListarPorId(id);
                        PreencherDetalhes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o buscar CategoriaDespesa: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Deseja realmente exlcuir este item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(dgvCategorias.Rows[e.RowIndex].Cells["CellIdCategoriaDespesa"].Value);
                            this.CategoriaDespesa = new CategoriaDespesa() { IdCategoriaDespesa = id };
                            new CategoriaDespesaController().Excluir(this.CategoriaDespesa);
                            LimparDetalhes();
                            BuscarCategoriaDespesas();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o excluir CategoriaDespesa: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
