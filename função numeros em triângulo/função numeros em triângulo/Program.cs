using System;

namespace função_numeros_em_triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0, c = 0;
            Console.WriteLine("Escolha a quantidade de Colunas de um retângulo:");
            Console.WriteLine("Colunas");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a quantidade de Linhas de um retângulo:");
            Console.WriteLine("Linhas");
            c = int.Parse(Console.ReadLine());


            PrintRetangulo(c, l);

        }

        static void PrintRetangulo(int linha, int colunas)
        {
            char A='m';
            for (int j = 1; j <= linha; j++)
            {
                Console.WriteLine(" ");

                for (int i = 1; i <= colunas; i++)
                {
                    
                    Console.Write(A);

                }
            }
           


        }
    }
}
