using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasModel
{
    public class ContaBancaria
    {
        public int IdContaBancaria { get; set; }
        public string Descricao { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public int Ativo { get; set; }

        public string ContaCombo { get => (Descricao == null ? "" : Descricao) + " | " + (Agencia == null ? "" : Agencia) + " | " + (Conta == null ? "" : Conta); }
    }
}
