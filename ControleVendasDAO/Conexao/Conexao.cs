using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasDAO.Conexao
{
    public static class Conexao
    {
        public static string StringConexao = "Data Source = " + Environment.MachineName + "; Initial Catalog = ControleVendas; Integrated Security = SSPI";
        public static string StringConexaoMaster = "Data Source = " + Environment.MachineName + "; Initial Catalog = master; Integrated Security = SSPI";
        //public static string StringConexao = "Data Source=" + Environment.MachineName + ";Initial Catalog=Food;User ID=user_infototal;Password=123@info99;Language=Portuguese";
    }
}
