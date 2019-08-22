using ControleVendas.Util;
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
    public partial class frmEstoqueAlterar : Form
    {
        private string strQuantidade = "";

        public string GetStrQuantidade()
        {
            return this.strQuantidade;
        }

        public frmEstoqueAlterar(string texto)
        {
            InitializeComponent();
            lblTexto.Text = texto;
        }

        private void frmEstoqueAlterar_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Informe a quantidade desejada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.Focus();
                return;
            }

            if (!Tools.IsNumeric(txtQuantidade.Text))
            {
                MessageBox.Show("A quantidade deve ser numérica.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return;
            }

            this.strQuantidade = txtQuantidade.Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.strQuantidade = "";
            this.Close();
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
            }
        }
    }
}
