using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            
            Console.WriteLine("digite um numero:");
            a = int.Parse(Console.ReadLine());

            Printlinha (a);

        }
        
        static void Printlinha (int num = 0)
            
            {
            int k = 1;
            
            for(k = 1; k <= num; k++ )
            {
                
                Console.Write(k + " ");
            }
        }


    }
}
