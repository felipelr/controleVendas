using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasModel
{
    public class Produto
    {
        public long IdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Estoque { get; set; }
        public decimal Custo { get; set; }
        public decimal PrecoVenda { get; set; }
        public Unidade Unidade { get; set; }
        public Marca Marca { get; set; }
        public int Ativo { get; set; }

        public string GetDescricaoCompleta()
        {
            string desc = string.IsNullOrEmpty(this.Descricao) ? "" : this.Descricao;

            if (this.Unidade != null)
                desc += string.IsNullOrEmpty(this.Unidade.Descricao) ? "" : " - " + this.Unidade.Descricao;

            if (this.Marca != null)
                desc += string.IsNullOrEmpty(this.Marca.Descricao) ? "" : " - " + this.Marca.Descricao;

            return desc;
        }
    }
}
