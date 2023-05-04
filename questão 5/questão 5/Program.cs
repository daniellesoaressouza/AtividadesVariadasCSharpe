using System;

namespace questão_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int soma = 0;
            n = int.Parse(Console.ReadLine());

            while(n<1)
            {
                Console.WriteLine("Escolha um número maior que 1.");
                n = int.Parse(Console.ReadLine());
            }
            for(int i = 1; i<=n;i++)
            {
                if(i%2==0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("soma de todos numero pares entre 1 e"+" "+n+" "+"é"+" "+soma);


        }
    }
}
