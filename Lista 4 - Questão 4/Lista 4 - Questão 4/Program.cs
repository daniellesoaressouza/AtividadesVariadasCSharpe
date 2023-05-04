using System;

namespace Lista_4___Questão_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 1;
            int soma = 1;
            for (int i = 1; i <= 64; i++)
            {
                inicio = inicio * 2;
                soma += inicio;
                Console.WriteLine(soma);
            }
        }
    }
}
