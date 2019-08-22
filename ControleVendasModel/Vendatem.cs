using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasModel
{
    public class Vendatem
    {
        public long IdVendaItem { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Custo { get; set; }
        public decimal CustoTotal { get; set; }
        public Venda Venda { get; set; }
    }
}
