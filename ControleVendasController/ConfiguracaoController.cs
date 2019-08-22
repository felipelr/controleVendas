using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleVendasDAO;

namespace ControleVendasController
{
    public class ConfiguracaoController
    {
        public string VerificarBancoDados()
        {
            try
            {
                return new ConfiguracaoDAO().VerificarBancoDados();
            }
            catch
            {
                throw;
            }
        }

        public void InicializarBancoDados()
        {
            try
            {
                new ConfiguracaoDAO().InicializarBancoDados();
            }
            catch
            {
                throw;
            }
        }
    }
}
