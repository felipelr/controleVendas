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
    public class ContaMovimentacaoController : IBaseController<ContaMovimentacao>
    {
        public void Alterar(ContaMovimentacao model)
        {
            try
            {
                new ContaMovimentacaoDAO().Alterar(model);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(ContaMovimentacao model)
        {
            try
            {
                new ContaMovimentacaoDAO().Excluir(model);
            }
            catch
            {
                throw;
            }
        }

        public ContaMovimentacao Inserir(ContaMovimentacao model)
        {
            try
            {
                return new ContaMovimentacaoDAO().Inserir(model);
            }
            catch
            {
                throw;
            }
        }

        public ContaMovimentacao ListarPorId(long id)
        {
            try
            {
                return new ContaMovimentacaoDAO().ListarPorId(id);
            }
            catch
            {
                throw;
            }
        }

        public List<ContaMovimentacao> ListarTodos(string where)
        {
            try
            {
                return new ContaMovimentacaoDAO().ListarTodos(where);
            }
            catch
            {
                throw;
            }
        }
    }
}
