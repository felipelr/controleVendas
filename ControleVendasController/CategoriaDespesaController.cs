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
    public class CategoriaDespesaController : IBaseController<CategoriaDespesa>
    {
        public void Alterar(CategoriaDespesa model)
        {
            try
            {
                new CategoriaDespesaDAO().Alterar(model);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(CategoriaDespesa model)
        {
            try
            {
                new CategoriaDespesaDAO().Excluir(model);
            }
            catch
            {
                throw;
            }
        }

        public CategoriaDespesa Inserir(CategoriaDespesa model)
        {
            try
            {
                return new CategoriaDespesaDAO().Inserir(model);
            }
            catch
            {
                throw;
            }
        }

        public CategoriaDespesa ListarPorId(long id)
        {
            try
            {
                return new CategoriaDespesaDAO().ListarPorId(id);
            }
            catch
            {
                throw;
            }
        }

        public List<CategoriaDespesa> ListarTodos(string where)
        {
            try
            {
                return new CategoriaDespesaDAO().ListarTodos(where);
            }
            catch
            {
                throw;
            }
        }
    }
}
