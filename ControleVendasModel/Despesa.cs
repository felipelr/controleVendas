using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasModel
{
    public class Despesa
    {
        public long IdDespesa { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataDespesa { get; set; }
        public CategoriaDespesa Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int Status { get; set; }
    }
}
