using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção: \n 1)Multiplicação de 3 ");
            Console.WriteLine("Multiplicação de três números.");
            Console.WriteLine("  ");
            Console.WriteLine("Primeiro número");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("terceiro número");
            int z = int.Parse(Console.ReadLine());

            int resultado = Multi3(x, y,z);

            Console.WriteLine("Resultado:" + resultado);

        }

        static int Multi3 (int A,int B, int C)
        {
            int resultado = A * B * C;
            return resultado;
        }

        static float Divi2 (float i, float j)
        {
            float produto = i / j;
            return produto;
        }
    }
}
