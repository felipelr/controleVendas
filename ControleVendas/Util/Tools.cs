using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.Util
{
    public class Tools
    {
        public static bool IsNumeric(System.Object Expression)
        {
            if (Expression == null || Expression is DateTime)
                return false;

            if (Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Decimal || Expression is Boolean)
                return true;

            try
            {
                if (Expression is string)
                    Decimal.Parse(Expression as string);
                else
                    Decimal.Parse(Expression.ToString());
                return true;
            }
            catch
            {
            }
            return false;
        }

        public static void TextBoxMoeda(TextBox txt)
        {
            //Máscara Monetária
            try
            {
                String n = String.Empty;
                Decimal v = 0;
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                {
                    n = "000";
                }
                n = n.PadLeft(3, '0');

                if ((n.Length > 3) && (n.ToString().Substring(0, 1) == "0"))
                {
                    n = n.Substring(1, n.Length - 1);
                }
                v = Convert.ToDecimal(n) / 100;
                txt.Text = String.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch
            {
                txt.Text = "";
            }
        }

        public static DateTime PrimeiroDiadoMes(DateTime Data)
        {
            DateTime PrimeiroDiadoMes = DateTime.Parse("01" + Data.ToString("/MM/yyyy"));
            return PrimeiroDiadoMes;
        }

        public static DateTime UltimoDiadoMes(DateTime Data)
        {
            DateTime PrimeiroDiadoMes = DateTime.Parse("01" + Data.ToString("/MM/yyyy"));
            DateTime PrimeiroDiadoProximoMes = PrimeiroDiadoMes.AddMonths(1);
            DateTime UltimoDiadoMes = PrimeiroDiadoProximoMes.AddDays(-1);
            return UltimoDiadoMes;
        }
    }
}
