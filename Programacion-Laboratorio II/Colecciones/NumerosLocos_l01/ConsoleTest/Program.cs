using System;
using System.Collections.Immutable;
using System.Linq;

namespace ConsoleTest
{

    /*
     Crear una aplicación de consola que cargue 20 
    números enteros (positivos y negativos) 
    distintos de cero de forma aleatoria utilizando la clase Random.

    Mostrar el vector tal como fue ingresado.
    Luego mostrar los positivos ordenados en forma decreciente.
    Por último, mostrar los negativos ordenados en forma creciente.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] vector = new int[20];
            Random numerosRandom = new Random();

            Console.WriteLine("------------Cargando vector-----------------");
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = numerosRandom.Next(-100, 100);
                Console.WriteLine(vector[i]);
            }

            // numeros negativos

            Console.WriteLine("------------Negativos(decreciente) vector-----------------");

            Array.Sort(vector);
            foreach (int aux in vector)
            {
                if (aux < 0)
                {
                    Console.WriteLine(aux);
                }
            }

            // numeros positivos
            Console.WriteLine("------------Positivos(decreciente) vector-----------------");

            Array.Sort(vector);
            Array.Reverse(vector);
            foreach (int aux in vector)
            {
                if (aux > 0)
                {
                    Console.WriteLine(aux);
                }
            }
        }
    }
}
