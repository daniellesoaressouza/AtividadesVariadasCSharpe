using System;

namespace revisão1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um algoritmo que leia um número inteiro e exiba o seu antecessor e o seu sucessor.

            Console.WriteLine("Digite um número:");
            int num = int.Parse(Console.ReadLine());

            int sucessor = num+1;
            int antecessor = num-1;
            Console.WriteLine("Antecessor:" + " " + antecessor + "\nSucessor" + " " + sucessor);
            
        }
    }
}
