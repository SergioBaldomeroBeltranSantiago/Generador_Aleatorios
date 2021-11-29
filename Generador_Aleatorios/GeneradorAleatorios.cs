using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_Aleatorios
{
    class GeneradorAleatorios
    {
        public static decimal[] calcularAleatorioTransfInv(decimal[] pseudo,
                                         int r_inf,
                                         int r_sup)
        {
            //pseudo hace referencia a un número pseudoaleatorio.
            //r_inf es el rango inferior.
            //r_sup es el rango superior.

            //El método de la transformada inversa genera un número aleatorio
            //a partir de un número pseudoaleatorio, y un rango inferior y
            //superior.

            decimal[] aleatorio = new decimal[pseudo.Length];
            for (int i = 0; i < pseudo.Length; i++)
            {
                aleatorio[i] = r_inf + ((r_sup - r_inf) * pseudo[i]);
            }
            return aleatorio;
        }
    }
}
