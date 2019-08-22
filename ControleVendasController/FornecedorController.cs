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
    public class FornecedorController : IBaseController<Fornecedor>
    {
        public void Alterar(Fornecedor model)
        {
            try
            {
                new FornecedorDAO().Alterar(model);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(Fornecedor model)
        {
            try
            {
                new FornecedorDAO().Excluir(model);
            }
            catch
            {
                throw;
            }
        }

        public Fornecedor Inserir(Fornecedor model)
        {
            try
            {
                return new FornecedorDAO().Inserir(model);
            }
            catch
            {
                throw;
            }
        }

        public Fornecedor ListarPorId(long id)
        {
            try
            {
                return new FornecedorDAO().ListarPorId(id);
            }
            catch
            {
                throw;
            }
        }

        public List<Fornecedor> ListarTodos(string where)
        {
            try
            {
                return new FornecedorDAO().ListarTodos(where);
            }
            catch
            {
                throw;
            }
        }
    }
}
