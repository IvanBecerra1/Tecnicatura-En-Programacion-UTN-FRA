using Enumeraciones;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EjercisioAbstracionClase.Entidades
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Lavadero(/*List<Vehiculo> vehiculos, */float precioAuto, float precioCamion, float precioMoto) : this()
        {
           // this.vehiculos = vehiculos;
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

        public List<Vehiculo> Vehiculos { get => vehiculos; }

        /*
         Tendrá una propiedad de sólo lectura (Detalle : string) que retornará la información completa del lavadero: precios 
        vigentes y el listado completo de los vehículos que contiene. Reutilizar código.
        También poseerá una propiedad de sólo lectura Vehiculos, asociada a la lista genérica.
         */
        public string Detalle
        {
            get
            {
                StringBuilder text = new StringBuilder();

                foreach (Vehiculo aux in this.Vehiculos)
                {
                    text.AppendLine(aux.ToString());
                }
                text.AppendLine($"Precio Moto: {this.precioMoto}");
                text.AppendLine($"Precio Camion: {this.precioCamion}");
                text.AppendLine($"Precio Auto: {this.precioAuto}");
                return text.ToString();
            }
        }

        /*
         MostrarTotalFacturado: devolverá la ganancia total del lavadero (Double), dicho método tendrá una sobrecarga 
        que reciba como parámetro la enumeración EVehiculos (con Auto, Camión y Moto como enumerados) y 
        retornará la ganancia del Lavadero por tipo de vehículo.

         */
        public double MostrarTotalFacturado(EVehiculo vehiculo)
        {
            double precio = 0;
            int contador = 0;
            foreach (Vehiculo aux in this.vehiculos)
            {
                if (vehiculo == EVehiculo.AUTO && (aux is (Auto)))
                {
                    contador++;
                    precio = this.precioAuto * contador;
                }
                else if (vehiculo == EVehiculo.CAMION && (aux is (Camion)))
                {
                    contador++;
                    precio = this.precioCamion * contador;
                }
                else if (vehiculo == EVehiculo.MOTO && (aux is (Moto)))
                {
                    contador++;
                    precio = this.precioMoto * contador;
                }
            }

            return precio;
        }

        /*
          Los métodos que tendrá Lavadero son:
         MostrarTotalFacturado: devolverá la ganancia total del lavadero (Double), dicho método tendrá una sobrecarga 
        que reciba como parámetro la enumeración EVehiculos (con Auto, Camión y Moto como enumerados) y 
        retornará la ganancia del Lavadero por tipo de vehículo.
        */
        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool isVehiculo = false;
            foreach (Vehiculo aux in lavadero.Vehiculos)
            {
                if (vehiculo == aux) {
                    isVehiculo = true;
                    break;
                }
            }
            return isVehiculo;
        }

        /* Sobrecarga == entre un lavadero y un vehículo, retornara TRUE, si el vehículo se encuentra en el lavadero.*/
        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        /*     Sobrecarga del operador +, que agregara un vehículo siempre y cuando el vehículo no se encuentre en el 
        lavadero. Ej. miLavadero += unAuto;*/
        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (!(lavadero == vehiculo))
            {
                lavadero.Vehiculos.Add(vehiculo);
            }
            return lavadero;
        }

        /*
           Sobrecarga del operador -, que quitara al vehiculo del lavadero, siempre y cuando este dicho vehiculo. Ej. 
        miLavadero -= unaMoto;
         */
        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
            {
                lavadero.Vehiculos.Remove(vehiculo);
            }
            return lavadero;
        }
        /*
         Generar un método estático (OrdenarVehiculosPorPatente : int) que reciba dos vehículos y retorne un 0 (cero), 
        si ambas patentes son iguales, si la primera patente es ‘mayor’ que la segunda, retornará un 1 (uno) y si no, 
        retornará un -1 (menos uno).
        */
        public static int OrdenarVehiculosPorPatente(Vehiculo vehiculoA, Vehiculo vehiculoB)
        {
            return String.Compare(vehiculoA.Patente, vehiculoB.Patente);
        }

        /*
         Generar un método de instancia (OrdenarVehiculosPorMarca : int) que reciba dos vehículos retorne un 0 (cero), 
        si ambas marcas son iguales, si la primera marca es ‘mayor’ que la segunda, retornará un 1 (uno) y si no, 
        retornará un -1 (menos uno).
         */
        public static int OrdenarVehiculosPorMarca(Vehiculo vehiculoA, Vehiculo vehiculoB)
        {
            return (vehiculoA.Marca.CompareTo(vehiculoB.Marca));
        }
    }
}
