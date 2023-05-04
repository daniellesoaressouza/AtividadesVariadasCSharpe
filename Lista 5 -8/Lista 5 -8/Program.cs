using System;

namespace Lista_5__8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] VetorA = new int[10] { 25, 3, 6, 94, 12, 13, 21, 20, 25, 14 };
            int[] VetorB = new int[10] { 25, 7, 6, 44, 57, 13, 21, 32, 26, 14 };

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (VetorA[i] == VetorB[j])
                    {
                        Console.Write(VetorA[i]+"  ");
                    }
                }

            }
        }
    }
}
