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
    public partial class frmContaBancariaMovimentacaoFiltros : Form
    {
        private string descricao = "";
        private int tipo = 2;
        private DateTime dataDe = Tools.PrimeiroDiadoMes(DateTime.Now);
        private DateTime dataAte = Tools.UltimoDiadoMes(DateTime.Now);
        private List<ContaListItem> listaContas = new List<ContaListItem>();

        public string GetDescricao()
        {
            return this.descricao;
        }

        public int GetTipo()
        {
            return this.tipo;
        }

        public DateTime GetDataDe()
        {
            return this.dataDe;
        }

        public DateTime GetDataAte()
        {
            return this.dataAte;
        }

        public List<ContaListItem> GetListaContas()
        {
            return this.listaContas;
        }

        public frmContaBancariaMovimentacaoFiltros(string descricao, int tipo, DateTime dataDe, DateTime dataAte, List<ContaListItem> listaContas)
        {
            InitializeComponent();
            this.descricao = descricao;
            this.tipo = tipo;
            this.dataDe = dataDe;
            this.dataAte = dataAte;
            this.listaContas = listaContas;
        }

        private void frmContaBancariaMovimentacaoFiltros_Load(object sender, EventArgs e)
        {
            dtpDe.Value = this.dataDe;
            dtpAte.Value = this.dataAte;
            txtDescricao.Text = this.descricao;

            checklistContas.BeginUpdate();
            checklistContas.DataSource = new ContaBancariaController().ListarTodos("");
            checklistContas.DisplayMember = "Descricao";
            checklistContas.EndUpdate();

            foreach (ContaListItem conta in this.listaContas)
            {
                checklistContas.SetItemChecked(conta.Index, true);
            }

            if (this.tipo == ContaMovimentacao.TIPO_ENTRADA)
                rbtTipoEntrada.Checked = true;
            else if (this.tipo == ContaMovimentacao.TIPO_SAIDA)
                rbtTipoSaida.Checked = true;
            else
                rbtTipoTodos.Checked = true;

            checklistContas.ClearSelected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.descricao = txtDescricao.Text;
            this.tipo = rbtTipoEntrada.Checked ? ContaMovimentacao.TIPO_ENTRADA : rbtTipoSaida.Checked ? ContaMovimentacao.TIPO_SAIDA : 2;
            this.dataDe = dtpDe.Value;
            this.dataAte = dtpAte.Value;

            this.listaContas.Clear();
            foreach (int i in this.checklistContas.CheckedIndices)
            {
                ContaListItem item = new ContaListItem(this.checklistContas.Items[i] as ContaBancaria, i);
                this.listaContas.Add(item);
            }

            this.Close();
        }
    }

    public class ContaListItem : ContaBancaria
    {
        public ContaListItem(ContaBancaria conta, int index)
        {
            this.IdContaBancaria = conta.IdContaBancaria;
            this.Descricao = conta.Descricao;
            this.Agencia = conta.Agencia;
            this.Conta = conta.Conta;
            this.Index = index;
        }
        public int Index { get; set; }
    }
}
