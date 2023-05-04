using System;

namespace questão_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número e retornará o dia da semana correspondente.");
            num = int.Parse(Console.ReadLine());
            while(num>7)
            {
                Console.Clear();
                Console.WriteLine("Digite um número válido dentre a quantidade de dias que possui uma semana.");
                num = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(" ");
            Console.WriteLine("O dia da semana é:");
            Semana(num);
        }
        static void Semana(int n)
        {
            if (n == 1)
            {
                Console.WriteLine("Segunda-Feira");
            }
            if (n == 2)
            {
                Console.WriteLine("Terça-Feira");
            }
            if (n == 3)
            {
                Console.WriteLine("Quarta-Feira");
            }
            if (n == 4)
            {
                Console.WriteLine("Quinta-Feira");
            }
            if (n == 5)
            {
                Console.WriteLine("Sexta-Feira");
            }
            if (n == 6)
            {
                Console.WriteLine("Sábado");
            }
            if (n == 7)
            {
                Console.WriteLine("Domingo");
            }
        }
        }
}
