using System;

namespace questão_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número e retornará o mês correspondente.");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("O mês é:");
            Mes(num);
        }

        static void Mes(int n)
        {
            if(n == 1)
            {
                Console.WriteLine("Janeiro");
            }
            if (n == 2)
            {
                Console.WriteLine("Fevereiro");
            }
            if (n == 3)
            {
                Console.WriteLine("Março");
            }
            if (n == 4)
            {
                Console.WriteLine("Abril");
            }
            if (n == 5)
            {
                Console.WriteLine("Maio");
            }
            if (n == 6)
            {
                Console.WriteLine("Junho");
            }
            if (n == 7)
            {
                Console.WriteLine("Julho");
            }
            if (n == 8)
            {
                Console.WriteLine("Agosto");
            }
            if (n == 9 )
            {
                Console.WriteLine("Setembro");
            }
            if (n == 10)
            {
                Console.WriteLine("Outubro");
            }
            if (n == 11)
            {
                Console.WriteLine("Novembro");
            }
            if (n == 12)
            {
                Console.WriteLine("Dezembro");
            }
        }
    }
}
