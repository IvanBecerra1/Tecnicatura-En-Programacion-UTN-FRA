using Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercisioAbstracionClase.Entidades
{
    public sealed class Auto : Vehiculo
    {
        private int cantidadAsientos;

        public Auto(string patente, byte cantidadRuedas, EMarcas marca, int cantidadAsientos) : base(patente, cantidadRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }

        private string MostrarAuto()
        {
            return base.Mostrar() + $"Asientos: {this.cantidadAsientos}";
        }
        public override string ToString()
        {
            return MostrarAuto();
        }
    }
}
