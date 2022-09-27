using Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercisioAbstracionClase.Entidades
{
    public sealed class Moto : Vehiculo
    {
        private float cilindrada;

        public Moto(string patente, byte cantidadRuedas, EMarcas marca, float cilindrada) : base(patente, cantidadRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }

        private string MostrarMoto()
        {
            return base.Mostrar() + $"cilindrada: {this.cilindrada}";
        }

        public override string ToString()
        {
            return MostrarMoto();
        }
    }
}
