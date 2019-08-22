using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleVendasModel;
using ControleVendasController;
using ControleVendas.Util;

namespace ControleVendas.Views.Cadastros
{
    public partial class frmMarcaCadastro : Form
    {
        private Marca Marca = null;

        public frmMarcaCadastro()
        {
            InitializeComponent();
        }

        private void frmMarcaCadastro_Load(object sender, EventArgs e)
        {
            LimparDetalhes();
            BuscarMarcas();
            txtDescricao.Focus();
            txtDescricao.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarMarcas();
        }

        private void BuscarMarcas()
        {
            string where = "";
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (Tools.IsNumeric(txtBuscar.Text))
                    where = " AND idMarca = " + txtBuscar.Text + " ";
                else
                    where = " AND descricao LIKE '%" + txtBuscar.Text + "%' ";
            }

            List<Marca> lista = null;

            try
            {
                lista = new MarcaController().ListarTodos(where);
            }
            catch
            {
            }

            dgvMarca.Rows.Clear();

            if (lista != null)
            {
                foreach (Marca marca in lista)
                {
                    dgvMarca.Rows.Add(marca.IdMarca,
                        marca.Descricao,
                        Properties.Resources.ic_edit_preto_24,
                        Properties.Resources.ic_excluir_preto_24);
                }
                dgvMarca.ClearSelection();
            }
        }

        private void PreencherDetalhes()
        {
            txtIdMarca.Text = this.Marca.IdMarca.ToString();
            txtDescricao.Text = this.Marca.Descricao;
        }

        private void LimparDetalhes()
        {
            this.Marca = null;
            this.txtIdMarca.Text = "";
            this.txtDescricao.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.Marca == null)
            {
                this.Marca = new Marca();
                this.Marca.Descricao = txtDescricao.Text.Trim();

                try
                {
                    this.Marca = new MarcaController().Inserir(this.Marca);
                    LimparDetalhes();
                    BuscarMarcas();
                }
                catch (Exception ex)
                {
                    this.Marca = null;
                    MessageBox.Show("Problemas o inserir marca: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.Marca.Descricao = txtDescricao.Text;

                try
                {
                    new MarcaController().Alterar(this.Marca);
                    LimparDetalhes();
                    BuscarMarcas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas o alterar marca: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDetalhes();
        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 2)
                {
                    try
                    {
                        long id = Convert.ToInt64(dgvMarca.Rows[e.RowIndex].Cells["CellIdMarca"].Value);
                        this.Marca = new MarcaController().ListarPorId(id);
                        PreencherDetalhes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o buscar Marca: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Deseja realmente exlcuir este item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(dgvMarca.Rows[e.RowIndex].Cells["CellIdMarca"].Value);
                            this.Marca = new Marca() { IdMarca = id };
                            new MarcaController().Excluir(this.Marca);
                            LimparDetalhes();
                            BuscarMarcas();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problemas o excluir Marca: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
