using System;
using System.Data.Common;
using System.Linq;

namespace Libreria
{
    public class Sumador
    {
        private int cantidadSumas;

        /**/
        public Sumador()
        {
            this.cantidadSumas = 0;
        }
        public Sumador(int cantidadSumas) : this()
        {
            this.cantidadSumas = cantidadSumas;
        }
        /**/

        public long Sumar(long numeroA, long numeroB)
        {
            this.cantidadSumas++;
            return numeroA + numeroB;
        }

        public string Sumar(string textoA, string textoB)
        {
            this.cantidadSumas++;
            return String.Concat(textoA, textoB);
        }

        // Requiere casteo.
        public static explicit operator int(Sumador sumar)
        {
            return sumar.cantidadSumas;
        }

        public static bool operator |(Sumador sumadorA, Sumador sumadorB)
        {
            return ((int)sumadorA == (int)sumadorB);
        }

        public static long operator +(Sumador sumadorA, Sumador sumadorB)
        {
            return (int) sumadorA + (int)sumadorB;
        }
    }
}
