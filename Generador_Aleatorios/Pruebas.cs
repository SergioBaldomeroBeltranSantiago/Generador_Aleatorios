using System;
using System.Collections.Generic;
using System.Text;

namespace Generador_Aleatorios
{
    class Pruebas
    {
        public static bool PruebaMaestra(float aceptacion, decimal[] conjunto) {
            bool resultado = true;
            return resultado;
        }

        public static bool PruebaMedias(float aceptacion, decimal[] conjunto) {
            decimal suma = 0;
            foreach (decimal num in conjunto) {
                suma += num;
            }
            decimal promedio = suma / conjunto.Length;
            return true;
        }
    }
}
