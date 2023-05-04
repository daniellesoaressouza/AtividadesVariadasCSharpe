using System;

namespace Lista_4___Questão_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valor de X:");
            float x = float.Parse(Console.ReadLine());

            ValorF(x);
        }
        static void ValorF(double i)
        {
            double p1 = ((5 * i) + 3);
            double p2 = Math.Sqrt(i*i);
            double p3 = Math.Sqrt(16);
            double resposta = p1 / (p2 - p3);
            Console.WriteLine("Valor de F:" + " " + resposta);
        }
    }
}
