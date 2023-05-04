using System;

namespace lista_5___5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor20 = new int[20] { 20, 33, 66, 51, 20, 3, 25, 69, 6, 5, 14, 17, 9, 12, 7, 23, 24, 25, 1, 4 };

            int i, x;

            int flag = 0;

            Console.WriteLine("Digite um valor X para a busca:\n");

            x = int.Parse(Console.ReadLine());

            for (i = 1; i < 20; i++)
            {

                if (x == Vetor20[i])
                {

                    Console.WriteLine("valor encontrado na posicao {0}", i);

                    flag = 1;

                }

            }

            if (flag == 0)
            {

                Console.WriteLine("valor nao encontrado!\n");

            }
        }
    }





}
        

