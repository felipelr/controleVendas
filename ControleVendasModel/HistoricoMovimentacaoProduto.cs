using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasModel
{
    public class HistoricoMovimentacaoProduto
    {
        public Produto Produto { get; set; }
        public decimal QuantidadeSaida { get; set; }
        public decimal QuantidadeEntrada { get; set; }
        public decimal EstoqueAtual { get; set; }
    }
}
