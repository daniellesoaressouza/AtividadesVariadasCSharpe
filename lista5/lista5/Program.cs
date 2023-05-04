using System;

namespace lista5
{
    class Program
    {
        static void Main(string[] args)
        {
            //05 - Para que a divisão entre 2 números possa ser realizada, o divisor não pode ser nulo.
            //Faça um programa para ler 2 valores e imprimir o resultado da divisão do primeiro pelo segundo.
            
            Console.WriteLine("Digite o dividendo:");
            double dividendo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o divisor:");
            double divisor = int.Parse(Console.ReadLine());

            do
            {
               
                Console.Clear();
                Console.WriteLine("O dividendo não pode ser nulo. Repita.");
                Console.WriteLine("Digite o dividendo:");
                dividendo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o divisor:");
                divisor = int.Parse(Console.ReadLine());
                Console.WriteLine("Quociente: " + (dividendo / divisor));

            }
            while (divisor <= 0);
            }

        }
    }

