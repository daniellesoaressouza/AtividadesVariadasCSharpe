using System;

namespace Lista_5___3
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Quantos números terá a sequência?");
            int indice = int.Parse(Console.ReadLine());
            int[] Numeros = new int[indice];

            
            for(int i = 0; i < indice;i++)
            {
                Console.Write("{0}: ",i);
                Numeros[i] = int.Parse(Console.ReadLine());
            }
          
            for (int i = indice - 1; i >=0 ;i--)
            {
                Console.Write("{0} ", Numeros[i]);
            }
            

        }
    }
}
