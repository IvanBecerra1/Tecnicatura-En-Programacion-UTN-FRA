using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercisioIntegrador.Entidades
{
    public sealed class Gato : Mascota
    {

        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }

        protected override string Ficha()
        {
            return $"gato - {DatosCompletos()}";
        }

        public override string ToString()
        {
            return Ficha();
        }
        public override bool Equals(object obj)
        {
            if (obj is Gato)
            {
                return this == (Gato)obj;
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return GetHashCode();
        }

        public static bool operator ==(Gato gatoA, Gato gatoB)
        {
            if (gatoA is null || gatoB is null)
                return false;

            return gatoA == (Mascota)gatoB;
        }

        public static bool operator !=(Gato gatoA, Gato gatoB)
        {
            if (gatoA is null || gatoB is null)
                return false;

            return !(gatoA == (Mascota)gatoB);
        }
    }
}
