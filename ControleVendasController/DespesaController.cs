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
    public class DespesaController : IBaseController<Despesa>
    {
        public void Alterar(Despesa model)
        {
            try
            {
                new DespesaDAO().Alterar(model);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(Despesa model)
        {
            try
            {
                new DespesaDAO().Excluir(model);
            }
            catch
            {
                throw;
            }
        }

        public Despesa Inserir(Despesa model)
        {
            try
            {
                return new DespesaDAO().Inserir(model);
            }
            catch
            {
                throw;
            }
        }

        public Despesa ListarPorId(long id)
        {
            try
            {
                return new DespesaDAO().ListarPorId(id);
            }
            catch
            {
                throw;
            }
        }

        public List<Despesa> ListarTodos(string where)
        {
            try
            {
                return new DespesaDAO().ListarTodos(where);
            }
            catch
            {
                throw;
            }
        }

        public void PagarDespesa(long idDespesa)
        {
            try
            {
                new DespesaDAO().PagarDespesa(idDespesa);
            }
            catch
            {
                throw;
            }
        }
    }
}
