using ControleVendasController.Interfaces;
using ControleVendasModel;
using ControleVendasDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasController
{
    public class UnidadeController : IBaseController<Unidade>
    {
        public void Alterar(Unidade model)
        {
            try
            {
                new UnidadeDAO().Alterar(model);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(Unidade model)
        {
            try
            {
                new UnidadeDAO().Excluir(model);
            }
            catch
            {
                throw;
            }
        }

        public Unidade Inserir(Unidade model)
        {
            try
            {
                return new UnidadeDAO().Inserir(model);
            }
            catch
            {
                throw;
            }
        }

        public Unidade ListarPorId(long id)
        {
            try
            {
                return new UnidadeDAO().ListarPorId(id);
            }
            catch
            {
                throw;
            }
        }

        public List<Unidade> ListarTodos(string where)
        {
            try
            {
                return new UnidadeDAO().ListarTodos(where);
            }
            catch
            {
                throw;
            }
        }
    }
}
