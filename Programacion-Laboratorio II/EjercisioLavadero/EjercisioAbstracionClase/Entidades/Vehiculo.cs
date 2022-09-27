using System;
using System.Data.Common;
using Enumeraciones;

namespace EjercisioAbstracionClase.Entidades
{
    public abstract class Vehiculo
    {
        protected string patente;
        protected Byte cantidadRuedas;
        protected EMarcas marca;

        public Vehiculo(string patente, byte cantidadRuedas, EMarcas marca)
        {
            this.Patente = patente;
            this.cantidadRuedas = cantidadRuedas;
            this.marca = marca;
        }

        public EMarcas Marca { get => marca; set => marca = value; }
        public string Patente { get => patente; set => patente = value; }

        public override bool Equals(Object obj)
        {
            if (obj is Vehiculo)
                return (this == ((Vehiculo)obj));
            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public static bool operator ==(Vehiculo vehiculoA, Vehiculo VehiculoB)
        {
            return (vehiculoA.Patente == VehiculoB.Patente) && (vehiculoA.marca == VehiculoB.marca);
        }
        public static bool operator !=(Vehiculo vehiculoA, Vehiculo VehiculoB)
        {
            return (vehiculoA == VehiculoB);
        }

        protected string Mostrar()
        {
            return $"patente {this.Patente} - ruedas {this.cantidadRuedas} - marca {this.marca.ToString()} - ";
        }
        public override string ToString()
        {
            return Mostrar();
        }
    }
}
