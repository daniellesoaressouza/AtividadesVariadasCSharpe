using System;

namespace Lista_4___Questão_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor atual do salário:");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor do reajuste:(lido em %)");
            double reajuste = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            REAJUSTE(salario, reajuste);


        }
        static void REAJUSTE(double a, double b)
        {
            double aumento = ((a * b )/ 100);
            double salario = a + aumento;
            Console.WriteLine("Seu salário passa a ser:" + " " + "R$" + salario);
        }
    }
}
