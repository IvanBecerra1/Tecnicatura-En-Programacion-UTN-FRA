using Libreria;
using System;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Sumador classSumadorA = new Sumador(2);
            Sumador classSumadorB = new Sumador(0);

            Console.WriteLine(classSumadorA.Sumar(10, 10));
            Console.WriteLine(classSumadorB.Sumar("Java", "Lovers"));

            int numA = (int) classSumadorA;
            int numB = (int) classSumadorB;

            Console.WriteLine($"SumA = {numA}\nSumB = {numB}");

            Console.WriteLine(classSumadorA + classSumadorB);
            Console.WriteLine(classSumadorA | classSumadorB);


        }
    }
}
