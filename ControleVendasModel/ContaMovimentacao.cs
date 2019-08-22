using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasModel
{
    public class ContaMovimentacao
    {
        public const int TIPO_ENTRADA = 0;
        public const int TIPO_SAIDA = 1;

        public long IdContaMovimentacao { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public int TipoMovimentacao { get; set; }
        public ContaBancaria ContaBancaria { get; set; }        
    }
}
