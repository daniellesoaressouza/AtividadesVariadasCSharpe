using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //o maior divisor de 2352134 que seja primo.
            int num = 2352134;
            bool primo;

            for (int i = 1; i <= 2352134; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);




                }

            }
            */

        
            
            int num;
            bool primo = true;
            bool par = true;
            Console.WriteLine("Digite um número para saber se ele é primo:");
            num = int.Parse(Console.ReadLine());

            if (num == 1 || num == 0)
            {
                Console.WriteLine("Não é primo");
            }
            else
            {
                for (int a = 2; a <= (num / 2); a++)
                {
                    if (num % a == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo)
                {
                    Console.WriteLine("Número primo!");
                }

                else
                {
                    Console.WriteLine("Este número não é primo.");
                }
            }
            
                if (num % 2 != 0)
                {
                    par = false;
                    
                }
            

                if (par)
               {
                Console.WriteLine("Número par");
                }

               else
               {
                Console.WriteLine("Número impar");
               }
            

        }
            }
                
          
                    

                 

            
           
         

             
        }
    

