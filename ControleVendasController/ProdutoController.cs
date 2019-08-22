using ControleVendasController.Interfaces;
using ControleVendasDAO;
using ControleVendasModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasController
{
    public class ProdutoController : IBaseController<Produto>
    {
        public void Alterar(Produto model)
        {
            try
            {
                new ProdutoDAO().Alterar(model);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(Produto model)
        {
            try
            {
                new ProdutoDAO().Excluir(model);
            }
            catch
            {
                throw;
            }
        }

        public Produto Inserir(Produto model)
        {
            try
            {
                return new ProdutoDAO().Inserir(model);
            }
            catch
            {
                throw;
            }
        }

        public Produto ListarPorId(long id)
        {
            try
            {
                return new ProdutoDAO().ListarPorId(id);
            }
            catch
            {
                throw;
            }
        }

        public List<Produto> ListarTodos(string where)
        {
            try
            {
                return new ProdutoDAO().ListarTodos(where);
            }
            catch
            {
                throw;
            }
        }

        public long ProximoId()
        {
            try
            {
                return new ProdutoDAO().ProximoId();
            }
            catch
            {
                throw;
            }
        }

        public List<HistoricoMovimentacaoProduto> HistoricoMovimentacaoProdutos(string where)
        {
            try
            {
                return new ProdutoDAO().HistoricoMovimentacaoProdutos(where);
            }
            catch
            {
                throw;
            }
        }

        public List<String> ListarTiposHistorico()
        {
            try
            {
                return new ProdutoDAO().ListarTiposHistorico();
            }
            catch
            {
                throw;
            }
        }
    }
}
