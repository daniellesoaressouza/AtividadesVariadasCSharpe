using System;

namespace revisao1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Real para Dólar hoje (22/03/2022).");
            Console.WriteLine("Valor em real:");
            double real = double.Parse(Console.ReadLine());

            double dolar = (real / 4.93);
            Console.WriteLine("Valor em US$" + dolar);

        }
    }
}
