using Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercisioAbstracionClase.Entidades
{
    public sealed class Camion : Vehiculo
    {
        private float tara;

        public Camion(string patente, byte cantidadRuedas, EMarcas marca, float tara) : base(patente, cantidadRuedas, marca)
        {
            this.tara = tara;
        }

        private string MostrarCamion()
        {
            return base.Mostrar() + $"Tara: {this.tara}";
        }
        public override string ToString()
        {
            return MostrarCamion();
        }

    }
}
