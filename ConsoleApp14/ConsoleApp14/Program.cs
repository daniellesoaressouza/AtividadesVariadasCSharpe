using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int tri = 1;
            PrintTriangulo();
        }
      static void PrintTriangulo()
        {
            for(int i = 1; i <= 100;i++ )
            {
                Console.WriteLine(" ");
                for(int b = 1; b <= i
                    ; b++ )
                {
                    Console.Write(b++);   
                }

            }
        }
    }
}
