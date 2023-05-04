using System;

namespace Questão_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a; double b;
            Console.WriteLine("Escolha o primeiro número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número:");
            b = int.Parse(Console.ReadLine());


            Media(a, b);
            Diferenca(a, b);
            Produto(a, b);
            Divi(a, b);

        }
        static void Media(double a, double b)
        {
            Console.WriteLine("A média desses números é:" + " " + ((a + b )/ 2));
        }
        static void Diferenca(double a,double b)
        {
            if(a>b)
            {
                Console.WriteLine("A diferença é:" + " " + (a - b));
            }
            if (a < b)
            {
                Console.WriteLine("A diferença é:" + " " + (b-a));
            }
        }
        static void Produto(double c, double d)
        {
            Console.WriteLine("A soma é" + " " + (c + d));
        }
        static void Divi(double a, double b)
        {
            Console.WriteLine("A divisão do primeiro pelo segundo é" + " " + (a / b));
        }
    }
}
