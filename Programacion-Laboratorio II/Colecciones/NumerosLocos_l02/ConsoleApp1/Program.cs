using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Persona
        {
            private string nombre;
            private string apellido;

            public Persona(string nombre, string apellido)
            {
                this.nombre = nombre;
                this.apellido = apellido;
            }


            public override string ToString()
            {
                return $"Persona =  nombre: {this.nombre} - apellido: {this.apellido}";
            }
        }

        sealed class Programador : Persona
        {
            private string profesion;

            public Programador(string nombre, string apellido, string profesion) 
                    : base(nombre,apellido)
            {
                this.profesion = profesion;
            }

            public override string ToString()
            {
                return $"{base.ToString()} - Profesion: {this.profesion}"; 
            }
        }
        static void Main(string[] args)
        {
            Persona classPersona = new Programador("Ivan", "Becerra", "Programador");
            Console.WriteLine($"{classPersona.ToString()}");

            Programador pp = (Programador) new Persona("asd", "ad");
        }

        static void otro()
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
