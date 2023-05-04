using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            //A) Soma de todos os multiplos de 3 e 5 abaixo de 500.
            int A = 3;
            int B = 5;
            int somaA = 0;



            for (int i = 0; i < 500; i++)
            {
                if (i % A == 0 && i % B == 0)
                {
                    somaA += i;

                }
            }
            Console.WriteLine(somaA);

            //B) Soma de todos os multiplos de 3 ou 5 abaixo de 500.

            int x = 3;
            int y = 5;
            int somax = 0;
            

            for (int j = 0; j < 500; j++)
            {
                if (j % x == 0 || j % y == 0)
                {
                    somax += j;
                }

            }
            Console.WriteLine(somax);








        }
    }
}

