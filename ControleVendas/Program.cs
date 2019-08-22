using ControleVendas.Views.Dashboard;
using ControleVendas.Views.Login;
using ControleVendasController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string statusBanco = "SUCESSO";

            try
            {
                statusBanco = new ConfiguracaoController().VerificarBancoDados();
            }
            catch
            {
                statusBanco = "ERRO";
            }

            if (statusBanco == "ERRO")
            {
                //inicializar banco de dados
                try
                {
                    new ConfiguracaoController().InicializarBancoDados();
                    statusBanco = "";
                }
                catch (Exception ex)
                {
                    statusBanco = "ERRO: " + ex.Message;
                }
            }

            if (statusBanco != "SUCESSO")
            {
                MessageBox.Show(statusBanco, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }

            new frmLogin().ShowDialog();

            Application.Run(new frmDashboard());
        }
    }
}
