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
    public partial class frmUnidadeCadastro : Form
    {
        private Unidade Unidade = null;

        public frmUnidadeCadastro()
        {
            InitializeComponent();
        }

        private void frmUnidadeCadastro_Load(object sender, EventArgs e)
        {
            LimparDetalhes();
            BuscarUnidades();
            txtDescricao.Focus();
            txtDescricao.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUnidades();
        }

        private void BuscarUnidades()
        {
            string where = "";
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (Tools.IsNumeric(txtBuscar.Text))
                    where = " AND idUnidade = " + txtBuscar.Text + " ";
                else
                    where = " AND descricao LIKE '%" + txtBuscar.Text + "%' ";
            }

            List<Unidade> lista = null;

            try
            {
                lista = new UnidadeController().ListarTodos(where);
            }
            catch
            {
            }

            dgvUnidades.Rows.Clear();

            if (lista != null)
            {
                foreach (Unidade unidade in lista)
                {
                    dgvUnidades.Rows.Add(unidade.IdUnidade,
                        unidade.Descricao,
                        Properties.Resources.ic_edit_preto_24,
                        Properties.Resources.ic_excluir_preto_24);
                }
                dgvUnidades.ClearSelection();
            }
        }

        private void PreencherDetalhes()
        {
            txtIdUnidade.Text = this.Unidade.IdUnidade.ToString();
            txtDescricao.Text = this.Unidade.Descricao;
        }

        private void LimparDetalhes()
        {
            this.Unidade = null;
            this.txtIdUnidade.Text = "";
            this.txtDescricao.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.Unidade == null)
            {
                this.Unidade = new Unidade();
                this.Unidade.Descricao = txtDescricao.Text.Trim();

                try
                {
                    this.Unidade = new UnidadeController().Inserir(this.Unidade);
                    LimparDetalhes();
                    BuscarUnidades();
                }
                catch (Exception ex)
                {
                    this.Unidade = null;
                    MessageBox.Show("Problemas o inserir unidade: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.Unidade.Descricao = txtDescricao.Text;

                try
                {
                    new UnidadeController().Alterar(this.Unidade);
                    LimparDetalhes();
                    BuscarUnidades();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas o alterar unidade: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparDetalhes();
        }

        private void dgvUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 2)
                {
                    try
                    {
                        long id = Convert.ToInt64(dgvUnidades.Rows[e.RowIndex].Cells["CellIdUnidade"].Value);
                        this.Unidade = new UnidadeController().ListarPorId(id);
                        PreencherDetalhes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o buscar unidade: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Deseja realmente exlcuir este item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(dgvUnidades.Rows[e.RowIndex].Cells["CellIdUnidade"].Value);
                            this.Unidade = new Unidade() { IdUnidade = id };
                            new UnidadeController().Excluir(this.Unidade);
                            LimparDetalhes();
                            BuscarUnidades();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o excluir unidade: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
