using System;

namespace Lista_4___Questão_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = 'b';
            while (op != 's')
            {
                Console.Clear();
                Console.WriteLine("Calculadora do índice de poluição que indústria de 3 grupos produzem.");
                Console.WriteLine("Qual o índice calculado?");
                double ind = double.Parse(Console.ReadLine());
               
                if (ind <= 0.05 && ind < 0.26)
                {
                    Console.WriteLine("Índice aceitável.");
                    Console.WriteLine("");
                    Console.WriteLine("Deseja encerrar o programa?");
                    op = char.Parse(Console.ReadLine());
                }
               else if (ind >= 0.3 && ind < 0.41)
                {
                    Console.WriteLine("Empresas do 1° grupo devem suspender suas atividades.");
                    Console.WriteLine("");
                    Console.WriteLine("Deseja encerrar o programa?");
                    op = char.Parse(Console.ReadLine());
                }
                else if (ind >= 0.4 && ind < 0.50)
                {
                    Console.WriteLine("Empresas do 1° e 2° grupo devem suspender suas atividades.");
                    Console.WriteLine("");
                    Console.WriteLine("Deseja encerrar o programa?");
                    op = char.Parse(Console.ReadLine());
                }
                else if (ind >= 0.49)
                {
                    Console.WriteLine("Empresas do 1°, 2° e 3° grupo devem suspender suas atividades.");
                    Console.WriteLine("");
                    Console.WriteLine("Deseja encerrar o programa?");
                    op = char.Parse(Console.ReadLine());
                }
            }
        }
    }
}
