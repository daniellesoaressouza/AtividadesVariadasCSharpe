using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // O maior número <100, que tenha a maior quantidade de divisores.
            int variaveis = 0;
            int quantidade = 0;
            
            for (int i = 1; i < 100; i++)
            {
                int divisores = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisores++;
                        
                    }
                    
                }
    
    
                if(i>variaveis && divisores>=quantidade)
                {
                    variaveis = i;
                    quantidade = divisores;
                }

            }

            Console.WriteLine("O número é:"+variaveis + "   " +"ele possui"+"  "+ quantidade +"  "+ "divisores.");
        }
    }
}
    

