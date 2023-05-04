using System;

namespace Questão_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("Escolha uma das seguintes formas para calcular a área em cm2: \n 1) Triângulo \n 2) Circulo \n 3) Losango \n 4) Trapézio \n 5) Sair da calculadora" );
            opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Medida da base:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Medida da altura:");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    AreaTri(b, h);
                }
                if (opcao == 2)
                {
                    Console.WriteLine("Medida do raio:");
                    double r = double.Parse(Console.ReadLine());
                    AreaCir(r);

                }
                if (opcao == 3)
                {
                    Console.WriteLine("Medida diagonal maior:");
                    double D = double.Parse(Console.ReadLine());
                    Console.WriteLine("Medida diagonal menor:");
                    double d = double.Parse(Console.ReadLine());

                    AreaLosan(D, d);
                }
            
        }
        static void AreaTri(double b, double h)
        {
            double area = 0;
            area = ((b * h) / 2);
            Console.WriteLine("Sua área é"+" "+area+"cm2");
        }
        static void AreaCir(double r)
        {
            double resp = 0;
            resp = 3.14 * Math.Pow(2, r);
            Console.WriteLine("Sua área é"+" "+resp+"cm2");

        }
        static void AreaLosan(double D, double d)
        {
            double area = 0;
            area = ((D * d) / 2);
            Console.WriteLine("Sua área é" + " " + area+"cm2");

        }
        static void AreaTrape(double B, double b, double h)
        {
            double area = 0;
            area = (((B + b) * h) / 2);
            Console.WriteLine("Sua área é" + " " + area + "cm2");
        }
    }
}
