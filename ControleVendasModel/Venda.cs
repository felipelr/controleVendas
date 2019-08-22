using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasModel
{
    public class Venda
    {
        public const int STATUS_ABERTO = 1;
        public const int STATUS_FINALIZADO = 2;
        public const int STATUS_CANCELADO = 3;

        public long IdVenda { get; set; }
        public decimal QuantidadeTotal { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataTermino { get; set; }
        public int Status { get; set; }

        public decimal CustoTotal { get; set; }
        public decimal LucroTotal { get; set; }
        public decimal MargemLucro { get; set; }

        public List<Vendatem> Itens { get; set; }

        public string StrStatus()
        {
            string name = "";
            switch (this.Status)
            {
                case 1:
                    name = "Aberta";
                    break;
                case 2:
                    name = "Finalizada";
                    break;
                case 3:
                    name = "Cancelada";
                    break;
                default:
                    name = "Desconhecido";
                    break;
            }
            return name;
        }
    }
}
