using System;

namespace Questão_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Tabela multiplicação do número" + " " + numero);
            Multi(numero);
            
        }
        static void Multi(int n)
        {
            for(int i =1; i<=15;i++)
            {

                Console.WriteLine(n +"x"+i+ "="+n * i);

            }
        }
    }
}
