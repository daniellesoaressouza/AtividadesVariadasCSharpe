using System;

namespace revisão1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular a soma de dois números e multiplicar o resultado pelo primeiro.
            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = num1 + num2;
            Console.WriteLine("Soma:" + " " + (resultado));
            Console.WriteLine("Multiplicação do resultado pelo primeiro n°:" + " " + (resultado * num1));



        }
    }
}
