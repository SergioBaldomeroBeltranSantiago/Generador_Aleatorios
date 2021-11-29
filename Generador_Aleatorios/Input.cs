using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Generador_Aleatorios
{
    class Input
    {
        public static void OnlyNumbers(KeyPressEventArgs entry)
        {
            if (Char.IsDigit(entry.KeyChar) ||
                Char.IsControl(entry.KeyChar) ||
                Char.IsSeparator(entry.KeyChar))
            {
                entry.Handled = false;
            }
            else
            {
                entry.Handled = true;
            }
        }

        public static bool PRHGCheck(string entrada)
        {
            int error = 0;
            foreach (char index in entrada.ToCharArray())
            {
                if (!Char.IsDigit(index) &&
                    !index.Equals('.') &&
                    !index.Equals(',') &&
                    !index.Equals(' ') &&
                    !Char.IsControl(index)) error++;
            }
            return error > 0 ? false : true;
        }

        public static decimal[] ReciveInput(string entrada)
        {
            decimal[] pseudo = new decimal[(Regex.Matches(entrada, @"\d.\d+").Count)];
            int index = 0;
            foreach (var a in Regex.Matches(entrada, @"\d.\d+"))
            {
                pseudo[index] = Convert.ToDecimal(a.ToString());
                index++;
            }
            return pseudo;
        }
    }
}
