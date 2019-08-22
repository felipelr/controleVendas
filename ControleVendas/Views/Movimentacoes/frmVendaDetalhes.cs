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
    public partial class frmVendaDetalhes : Form
    {
        private Venda venda;

        public frmVendaDetalhes(Venda venda)
        {
            InitializeComponent();
            this.venda = venda;
        }

        private void frmVendaDetalhes_Load(object sender, EventArgs e)
        {
            lblDataInicio.Text = this.venda.DataInicio.ToString("dd/MM/yyyy");
            lblStatus.Text = this.venda.StrStatus();
            lblQtdeItens.Text = this.venda.QuantidadeTotal.ToString("N2");
            lblValorTotal.Text = this.venda.ValorTotal.ToString("C2");

            foreach (Vendatem item in this.venda.Itens)
            {
                dgvItens.Rows.Add(item.Produto.IdProduto,
                    item.Produto.Descricao,
                    item.Quantidade.ToString("N2"),
                    item.ValorUnitario.ToString("C2"),
                    item.ValorTotal.ToString("C2"));
            }
            dgvItens.ClearSelection();
        }
    }
}
