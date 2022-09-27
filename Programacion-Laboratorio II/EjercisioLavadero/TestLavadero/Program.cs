using EjercisioAbstracionClase.Entidades;
using Enumeraciones;
using System;
using System.Collections.Generic;

namespace TestLavadero
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
             La aplicación debe poder ingresar vehículos de distintos tipos y marcas al lavadero, quitarlos, 
            obtener las ganancias 
            totales o por tipo de vehículo y mostrar los vehículos ingresados al lavadero ordenado por los distintos criterios.
            Realizar las pruebas de las clases en: 
            Proyecto de tipo Console Application.
            Proyecto de tipo WindowForms Application
             */
            Moto motoA = new Moto("ABC2", 2, EMarcas.ZANELLA, 2f);
            Moto motoB = new Moto("ABC32", 2, EMarcas.HONDA, 2f);

            Auto autoA = new Auto("ASDD", 4, EMarcas.FIAT, 4);
            Auto autoB = new Auto("ASD2", 4, EMarcas.FORD, 2);

            Camion camionA = new Camion("CMION1", 6, EMarcas.IVECO, 20f);
            Camion camionB = new Camion("CMION2", 4, EMarcas.IVECO, 50f);

            /*List<Vehiculo> listaVehiculo = new List<Vehiculo>();
            listaVehiculo.Add(motoA);
            listaVehiculo.Add(autoA);
            listaVehiculo.Add(camionA);*/

            Lavadero lavadero = new Lavadero(100, 250, 50);

            lavadero += motoA;
            lavadero += motoB;
            lavadero += autoA;
            lavadero += autoB;
            lavadero += camionA;
            lavadero += camionB;

            Console.WriteLine("---------------Detalle Normales------------------");
            Console.WriteLine(lavadero.Detalle);

            Console.WriteLine("---------------Ordenado por patente------------------");
            lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(lavadero.Detalle);

            Console.WriteLine("---------------Ordenado por Marca------------------");
            lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorMarca);
            Console.WriteLine(lavadero.Detalle);


            Console.WriteLine("---------------Precios------------------");
            Console.WriteLine("Facturado Auto: " + lavadero.MostrarTotalFacturado(EVehiculo.AUTO));
            Console.WriteLine("Facturado Moto: " + lavadero.MostrarTotalFacturado(EVehiculo.MOTO));
            Console.WriteLine("Facturado Camion: " + lavadero.MostrarTotalFacturado(EVehiculo.CAMION));


        }
    }
}
