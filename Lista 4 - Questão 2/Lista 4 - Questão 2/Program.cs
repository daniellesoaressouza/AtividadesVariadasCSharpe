using System;

namespace Lista_4___Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char r ='b';
            while (r != 's')
            {
                Console.Clear();

                Console.WriteLine("Escolha uma das opções de conversão: \n 1) Celsius P/ Fahrenheit \n 2) Fahrenheit P/ Celsius ");
                int resp = int.Parse(Console.ReadLine());

                if (resp == 1)
                {
                    Console.WriteLine("Qual a temperatura em Celsius?");
                    double cels = double.Parse(Console.ReadLine());

                    CpF(cels);
                    Console.WriteLine("Deseja encerrar o programa? digite s para sim e n para não");
                    r = char.Parse(Console.ReadLine());
                }
                if (resp == 2)
                {
                    Console.WriteLine("Qual a temperatura em Fahrenheit?");
                    double fahr = double.Parse(Console.ReadLine());

                    FpC(fahr);
                    Console.WriteLine("Deseja encerrar o programa? digite s para sim e n para não");
                    r = char.Parse(Console.ReadLine());

                }

            } 
            
            
        }
        static void CpF(double c)
        {
            double fahrenheit = 0;
            fahrenheit = (c * 1.8) + 32;
            Console.WriteLine("A temperatura em fahrenheit é:"+" "+fahrenheit+"°f");
        }
        static void FpC(double f)
        {
            double celsius = 0;
            celsius = (f - 32) / 1.8;
            Console.WriteLine("A temperatura em Celsius é:" + " " + celsius + "°c");
        }
    }
}
