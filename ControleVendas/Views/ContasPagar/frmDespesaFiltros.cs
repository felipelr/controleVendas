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
    public partial class frmDespesaFiltros : Form
    {
        private string descricao = "";
        private DateTime dataDe = DateTime.Now;
        private DateTime dataAte = DateTime.Now;
        private int pago = 2;
        private List<CatDespListItem> listaCategorias = new List<CatDespListItem>();
        private List<FornListItem> listaFornecedores = new List<FornListItem>();

        public string GetDescricao()
        {
            return this.descricao;
        }

        public DateTime getDataDe()
        {
            return dataDe;
        }
        public DateTime getDataAte()
        {
            return dataAte;
        }

        public List<CatDespListItem> GetListaCategorias()
        {
            return this.listaCategorias;
        }
        public List<FornListItem> GetListaFornecedores()
        {
            return this.listaFornecedores;
        }

        public int GetPago()
        {
            return this.pago;
        }

        public frmDespesaFiltros(string descricao, int pago, DateTime dataDe, DateTime dataAte, List<CatDespListItem> listaCategorias, List<FornListItem> listaFornecedores)
        {
            InitializeComponent();
            this.descricao = descricao;
            this.pago = pago;
            this.dataDe = dataDe;
            this.dataAte = dataAte;
            this.listaCategorias = listaCategorias;
            this.listaFornecedores = listaFornecedores;
        }

        private void frmDespesaFiltros_Load(object sender, EventArgs e)
        {
            dtpDe.Value = this.dataDe;
            dtpAte.Value = this.dataAte;
            txtDescricao.Text = this.descricao;

            checklistCategoria.BeginUpdate();
            checklistCategoria.DataSource = new CategoriaDespesaController().ListarTodos("");
            checklistCategoria.DisplayMember = "Descricao";
            checklistCategoria.EndUpdate();

            checklistFornecedor.BeginUpdate();
            checklistFornecedor.DataSource = new FornecedorController().ListarTodos("");
            checklistFornecedor.DisplayMember = "Nome";
            checklistFornecedor.EndUpdate();

            foreach (CatDespListItem categoria in this.listaCategorias)
            {
                checklistCategoria.SetItemChecked(categoria.Index, true);
            }

            foreach (FornListItem fornecedor in this.listaFornecedores)
            {
                checklistFornecedor.SetItemChecked(fornecedor.Index, true);
            }

            if (this.pago == 2)
                rbtPagoTodos.Checked = true;
            else if (this.pago == 1)
                rbtPagoSim.Checked = true;
            else if (this.pago == 0)
                rbtPagoNao.Checked = true;

            checklistCategoria.ClearSelected();
            checklistFornecedor.ClearSelected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.descricao = txtDescricao.Text;
            this.pago = rbtPagoTodos.Checked ? 2 : rbtPagoSim.Checked ? 1 : 0;
            this.dataDe = dtpDe.Value;
            this.dataAte = dtpAte.Value;

            this.listaCategorias.Clear();
            foreach (int i in this.checklistCategoria.CheckedIndices)
            {
                CatDespListItem item = new CatDespListItem(this.checklistCategoria.Items[i] as CategoriaDespesa, i);
                this.listaCategorias.Add(item);
            }

            this.listaFornecedores.Clear();
            foreach (int i in this.checklistFornecedor.CheckedIndices)
            {
                FornListItem item = new FornListItem(this.checklistFornecedor.Items[i] as Fornecedor, i);
                this.listaFornecedores.Add(item);
            }

            this.Close();
        }
    }

    public class CatDespListItem : CategoriaDespesa
    {
        public CatDespListItem(CategoriaDespesa categoria, int index)
        {
            this.IdCategoriaDespesa = categoria.IdCategoriaDespesa;
            this.Descricao = categoria.Descricao;
            this.Index = index;
        }
        public int Index { get; set; }
    }

    public class FornListItem : Fornecedor
    {
        public FornListItem(Fornecedor fornecedor, int index)
        {
            this.IdFornecedor = fornecedor.IdFornecedor;
            this.Nome = fornecedor.Nome;
            this.Index = index;
        }
        public int Index { get; set; }
    }
}
