using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_Aleatorios
{
    class GeneradorPseudoaleatorios
    {

        public static decimal[] CongruencialMultiplicativo(int g, int k, int raiz)
        {
            //variables g, k y raiz deben ser enteros positivos mayores a 0.
            //raiz ademas debe ser impar.

            // m = 2^g
            int m = (int)Math.Pow(2, g);

            // a = 5+8k
            int a = 5 + 8 * k;

            List<int> raices = new List<int>();
            List<decimal> resultados = new List<decimal>();

            bool ciclo_continuar = true;

            while (ciclo_continuar) {

                int paso_1 = raiz * a;

                int paso_2 = paso_1 % m;

                decimal paso_3 = Convert.ToDecimal(paso_2) / (m - 1);

                resultados.Add(paso_3);
                raices.Add(raiz);
                if (raices.Contains(paso_2)) break;
                raiz = paso_2;
            }
            decimal[] result = new decimal[resultados.Count];
            int index = 0;
            foreach (var resultado in resultados) {
                result[index] = resultado;
                index++;
            }
            return result;
        }
    }
}
