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
    public class MarcaController : IBaseController<Marca>
    {
        public void Alterar(Marca model)
        {
            try
            {
                new MarcaDAO().Alterar(model);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(Marca model)
        {
            try
            {
                new MarcaDAO().Excluir(model);
            }
            catch
            {
                throw;
            }
        }

        public Marca Inserir(Marca model)
        {
            try
            {
                return new MarcaDAO().Inserir(model);
            }
            catch
            {
                throw;
            }
        }

        public Marca ListarPorId(long id)
        {
            try
            {
                return new MarcaDAO().ListarPorId(id);
            }
            catch
            {
                throw;
            }
        }

        public List<Marca> ListarTodos(string where)
        {
            try
            {
                return new MarcaDAO().ListarTodos(where);
            }
            catch
            {
                throw;
            }
        }
    }
}
