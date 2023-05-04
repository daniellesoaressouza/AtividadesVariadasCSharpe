using System;

namespace Lista_5___7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int num = rnd.Next(-10, 10);
            int[] VetorN = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                VetorN[i] = rnd.Next(-10, 11);
                


                if (VetorN[i] < 0)
                {
                    VetorN[i] = 0;
                }
                Console.Write(VetorN[i] + " ");

            }

            
        }
    }
}
