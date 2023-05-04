using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
            int F1 = 0, F2 = 1, F3;

            Console.WriteLine("Insira quantos termos deseja imprimir");
            int Termos = int.Parse(Console.ReadLine());

            if (Termos == 2)
            {
                Console.WriteLine(F1);
                Console.WriteLine(F2);
            }
            
            else if ( Termos == 1)
            { 
                Console.WriteLine(F1);
            } 
               

             
            else 
            {
                Console.WriteLine(F1);
                Console.WriteLine(F2);

                for (int i = 0; i < Termos-2; i++)
                {

                    F3 = F1 + F2;
                    F1 = F2;
                    F2 = F3;

                    Console.WriteLine(F3);
                }
            }
            
            
           
            

        }
    }
}
