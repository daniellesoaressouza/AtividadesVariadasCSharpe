using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade = 0;
            bool idadeX = true;

            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("digite sua idade");
            idade = int.Parse(Console.ReadLine());

            if (idade < 30)
            {
                idadeX = false;

            }
                if (idadeX)
            {
                Console.WriteLine("idade verdadeira");


            }
                else
            {
                Console.WriteLine("idade falsa");
            }

        }
    }       
            
               
}
