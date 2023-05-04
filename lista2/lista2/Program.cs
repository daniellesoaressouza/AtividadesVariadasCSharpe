using System;

namespace lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            //02 - Leia 3 vetores de 9 posições e crie outro com o 1º terço do primeiro,
            //o 2° terço do segundo e o último terço do 3º. Escrever o vetor resultante ao final.
            int[] Vetor1 = new int[9];
            int[] Vetor2 = new int[9];
            int[] Vetor3 = new int[9];
            int[] Mistura = new int[9];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < Vetor1.Length; i++)
            {
                Vetor1[i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < Vetor2.Length; i++)
            {
                Vetor2[i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < Vetor3.Length; i++)
            {
                Vetor3[i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < Vetor1.Length; i++)
            {
                Console.Write(Vetor1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < Vetor1.Length; i++)
            {
                Console.Write(Vetor2[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < Vetor1.Length; i++)
            {
                Console.Write(Vetor3[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Mistura:");
            //Misturando os vetores.
            Mistura[0] = Vetor1[0];
            Mistura[1] = Vetor1[1];
            Mistura[2] = Vetor1[2];
            Mistura[3] = Vetor2[3];
            Mistura[4] = Vetor2[4];
            Mistura[5] = Vetor2[5];
            Mistura[6] = Vetor3[6];
            Mistura[7] = Vetor3[7];
            Mistura[8] = Vetor3[8];
            
           for(int i = 0; i<Mistura.Length;i++)
            {
                Console.Write(Mistura[i]+" ");
            }
        }

    }
}
