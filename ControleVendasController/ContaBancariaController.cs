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
    public class ContaBancariaController : IBaseController<ContaBancaria>
    {
        public void Alterar(ContaBancaria model)
        {
            try
            {
                new ContaBancariaDAO().Alterar(model);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(ContaBancaria model)
        {
            try
            {
                new ContaBancariaDAO().Excluir(model);
            }
            catch
            {
                throw;
            }
        }

        public ContaBancaria Inserir(ContaBancaria model)
        {
            try
            {
                return new ContaBancariaDAO().Inserir(model);
            }
            catch
            {
                throw;
            }
        }

        public ContaBancaria ListarPorId(long id)
        {
            try
            {
                return new ContaBancariaDAO().ListarPorId(id);
            }
            catch
            {
                throw;
            }
        }

        public List<ContaBancaria> ListarTodos(string where)
        {
            try
            {
                return new ContaBancariaDAO().ListarTodos(where);
            }
            catch
            {
                throw;
            }
        }
    }
}
