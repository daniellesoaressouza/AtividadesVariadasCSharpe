using System;

namespace Lista_5___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Ar = new int[5] { 1, 2, 3, 4, 5 };
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(Ar[i] + " ");
               if(Ar[i] % 2 != 0)
                {
                    soma += Ar[i];
                }
               
            }
            Console.WriteLine(" ");
            Console.WriteLine(soma);
            
        }
    }
}
