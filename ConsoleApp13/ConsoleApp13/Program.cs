using System;

namespace ConsoleApp13
{
    class program
    {
        static void main(string[] args)
        {
            int a = 0;
            
            Console.WriteLine("digite um numero:");
            a = int.Parse(Console.ReadLine());

            PrintLinha(a);
        }
        
         static void PrintLinha (int num = 0)
            
            {
            int k = 1;
            
            for(k = 1; k <= num; k++ )
            {
                
                Console.Write(k + " ");
            }
        }


    }
}
