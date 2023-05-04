using System;

namespace revisão1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[4];

            Console.WriteLine("Média de um aluno considerando 4 avaliações.");
            Console.WriteLine("Nota primeira avaliação:");
            notas[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota segunda avaliação:");
            notas[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota terceira avaliação:");
            notas[2] = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota quarta avaliação:");
            notas[3] = double.Parse(Console.ReadLine());

            double soma = 0;

            for (int i = 0; i<notas.Length;i++)
            { 
                soma = soma + notas[i];
            }
            Console.WriteLine("A média aritmética é:"+ " "+(soma/notas.Length));
        }
    }
}
