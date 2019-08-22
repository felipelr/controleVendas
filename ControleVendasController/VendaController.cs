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
    public class VendaController : IBaseController<Venda>
    {
        public void Alterar(Venda model)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Venda model)
        {
            try
            {
                new VendaDAO().Excluir(model);
            }
            catch
            {
                throw;
            }
        }

        public Venda Inserir(Venda model)
        {
            try
            {
                return new VendaDAO().Inserir(model);
            }
            catch
            {
                throw;
            }
        }

        public Venda ListarPorId(long id)
        {
            try
            {
                return new VendaDAO().ListarPorId(id);
            }
            catch
            {
                throw;
            }
        }

        public List<Venda> ListarTodos(string where)
        {
            try
            {
                return new VendaDAO().ListarTodos(where);
            }
            catch
            {
                throw;
            }
        }
    }
}
