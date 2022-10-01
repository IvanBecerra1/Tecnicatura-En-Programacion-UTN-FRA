using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercisioIntegrador.Entidades
{
    public sealed class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public override bool Equals(object obj)
        {
            if (obj is Perro)
            {
                return this == (Perro)obj;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }

        protected override string Ficha()
        {
            StringBuilder text = new StringBuilder();
            text.Append($"perro - {DatosCompletos()}");

            if (this.esAlfa)
                text.Append($" es alfa de la manada");

            text.Append($", edad: {edad}");
            
            return text.ToString();
        }

        public Perro(string nombre, string raza) : this(nombre, raza, 0, false)
        {
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public override string ToString()
        {
            return Ficha();
        }

        public static bool operator ==(Perro perroA, Perro perroB)
        {
            if (perroA is null || perroB is null)
                return false;

            return (Mascota)perroA == perroB && perroA.edad == perroB.edad;
        }

        public static bool operator !=(Perro perroA, Perro perroB)
        {
            if (perroA is null || perroB is null)
                return false;

            return !(perroA == perroB);
        }

        public static explicit operator int(Perro perroA)
        {
            return perroA.edad;
        }


    }
}
