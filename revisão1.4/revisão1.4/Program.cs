using System;

namespace revisão1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Área de um quadrado

            Console.WriteLine("Área de um quadrado.");
            Console.WriteLine("  ");
            Console.WriteLine("Médida um lado:");
            double lado = double.Parse(Console.ReadLine());

            Console.WriteLine("Área:" + " " + (lado * lado));

            //Área de um triângulo

            Console.WriteLine("Área de um triângulo.");
            Console.WriteLine("  ");
            Console.WriteLine("Médida da altura:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Médida da base:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Área do triângulo:" + " " + ((h * b) / 2));


        }
    }
}
